-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Client :  127.0.0.1
-- Généré le :  Lun 20 Novembre 2017 à 19:53
-- Version du serveur :  5.7.14
-- Version de PHP :  7.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `projet_glog`
--
CREATE DATABASE IF NOT EXISTS `projet_glog` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `projet_glog`;

grant all privileges on `projet_glog`.* to 'admin'@'localhost' identified by 'admin';
-- --------------------------------------------------------

--
-- Structure de la table `account`
--

CREATE TABLE `account` (
  `id_account` int(11) NOT NULL,
  `name_account` varchar(255) NOT NULL,
  `url_account` varchar(255) NOT NULL,
  `login_account` varchar(255) NOT NULL,
  `password_account` varchar(255) NOT NULL,
  `strength_account` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `update_account` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `account`
--

INSERT INTO `account` (`id_account`, `name_account`, `url_account`, `login_account`, `password_account`, `strength_account`, `id_user`, `update_account`) VALUES
(1, 'Facebook', 'facebook.com', 'user1@gmail.com', 'XxDark_Sasuke_du_93xX', 3, 1, '2017-01-18 00:00:00'),
(2, 'Twitter', 'twitter.com', 'user1@gmail.com', 'azerty', 1, 1, '2017-11-20 08:22:23'),
(3, 'Github', 'github.com', 'user1@gmail.com', 'xCq3D*45cU/b5%A(', 3, 1, '2017-11-20 09:36:24');

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE `user` (
  `id_user` int(11) NOT NULL,
  `password_user` varchar(255) NOT NULL,
  `login_user` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `user`
--

INSERT INTO `user` (`id_user`, `password_user`, `login_user`) VALUES
(1, 'mdp789', 'test1'),
(2, 'azerty123', 'user2'),
(3, 'Poiunbdu93', 'user3');

-- --------------------------------------------------------

--
-- Structure de la table `wifi`
--

CREATE TABLE `wifi` (
  `id_wifi` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `ssid` varchar(255) NOT NULL,
  `password_wifi` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `wifi`
--

INSERT INTO `wifi` (`id_wifi`, `id_user`, `ssid`, `password_wifi`) VALUES
(1, 1, 'bordeaux-inp', 'g28yD2v2tV6cCD6M'),
(2, 1, 'reaumur', 'w3re3Hw63TA3GyJ4');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`id_account`);

--
-- Index pour la table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`);

--
-- Index pour la table `wifi`
--
ALTER TABLE `wifi`
  ADD PRIMARY KEY (`id_wifi`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `account`
--
ALTER TABLE `account`
  MODIFY `id_account` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pour la table `user`
--
ALTER TABLE `user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pour la table `wifi`
--
ALTER TABLE `wifi`
  MODIFY `id_wifi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
