using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PasswordGenerator
    {
        private static PasswordGenerator instance = null;

        private Random rnd;
        private string characters;
        private string symbols;
        private string numerals;
        private PasswordGenerator()
        {
            rnd = new Random();
            characters = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ";
            symbols = "~!@#$%^&*()-_=+[]{};:,.<>/?";
            numerals = "0123456789";
        }
        /// <summary>
        /// Création du singleton
        /// </summary>
        public static PasswordGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PasswordGenerator();
                }
                return instance;
            }
        }

        /// <summary>
        /// Génère un mot de passe aléatoire
        /// </summary>
        /// <param name="sizePassword">taille du mot de passe</param>
        /// <param name="nbTotalNumerals">nombre de chiffres dans le mot de passe</param>
        /// <param name="nbTotalSymbols">nombre de symboles dans le mot de passe</param>
        public string GeneratePassword(int sizePassword, int nbTotalNumerals, int nbTotalSymbols)
        {
            if (nbTotalNumerals + nbTotalSymbols > sizePassword)
            {
                return null;
            }

            string password = "";

            for (int i = 0; i < nbTotalNumerals; i++)
            {
                password += numerals[rnd.Next(numerals.Length)];
            }
            for (int i = 0; i < nbTotalSymbols; i++)
            {
                password += symbols[rnd.Next(symbols.Length)];
            }
            while (password.Length != sizePassword)
            {
                password += characters[rnd.Next(characters.Length)];
            }

            string finalPassword = new string(password.OrderBy(r => rnd.Next()).ToArray());
            
            return finalPassword;
        }

        /// <summary>
        /// Défini la force d'un mot de passe
        /// </summary>
        /// <param name="password">le mot de passe</param>
        public int PasswordStrength(string password)
        {
            int nbUpperCase = 0;
            int nbLowerCase = 0;
            int nbDigits = 0;
            int nbSymbols = 0;

            int consecutiveUp = 0;
            int consecutiveLow = 0;
            int consecutiveDigits = 0;
            char lastChar = '\0';

            //Parcours du mot de passe
            foreach(char c in password)
            {
                if(Char.IsUpper(c))
                {
                    nbUpperCase++;
                    if(lastChar == c)
                    {
                        consecutiveUp++;
                    }
                }
                else if(Char.IsLower(c))
                {
                    nbLowerCase++;
                    if (lastChar == c)
                    {
                        consecutiveLow++;
                    }
                }
                else if (Char.IsSymbol(c))
                {
                    nbSymbols++;
                }
                else if (Char.IsDigit(c))
                {
                    nbDigits++;
                    if (lastChar == c)
                    {
                        consecutiveDigits++;
                    }
                }
                lastChar = c;
            }

            int strength = password.Length*4;
            strength += (password.Length-nbUpperCase)*2;
            strength += (password.Length-nbLowerCase) * 2;
            strength += nbDigits * 4;
            strength += nbSymbols * 6;

            //Paramètres requis
            int requirements = 0;
            if (password.Length >= 8)
            {
                requirements++;
            }
            if (nbUpperCase > 0)
            {
                requirements++;
            }
            if (nbLowerCase > 0)
            {
                requirements++;
            }
            if (nbDigits > 0)
            {
                requirements++;
            }
            if (nbSymbols > 0)
            {
                requirements++;
            }
            strength += requirements * 2;


            //Ne contient que des lettres
            if (password.Length == nbLowerCase + nbUpperCase)
            {
                strength -= password.Length;
            }
            //Ne contient que des nombres
            if(password.Length == nbDigits)
            {
                strength -= password.Length;
            }

            strength -= consecutiveUp * 2;
            strength -= consecutiveLow * 2;
            strength -= consecutiveDigits * 2;

            //Définition de la force
            if (strength<50)
            {
                return 1;//Faible
            }
            else if(strength >= 50 && strength < 80)
            {
                return 2;//Moyen
            }
            else
            {
                return 3;//Fort
            }
        }
    }
}
