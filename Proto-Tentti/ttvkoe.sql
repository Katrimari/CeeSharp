-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 02.06.2022 klo 10:15
-- Palvelimen versio: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ttvkoe`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `koetiedot`
--

CREATE TABLE `koetiedot` (
  `id` int(11) NOT NULL,
  `etunimi` varchar(25) NOT NULL,
  `sukunimi` varchar(35) NOT NULL,
  `sahkoposti` varchar(40) NOT NULL,
  `kayttaja` varchar(10) NOT NULL,
  `salasana` varchar(30) NOT NULL,
  `kurssi` varchar(25) NOT NULL,
  `tentti` varchar(10) NOT NULL,
  `kieli` varchar(5) NOT NULL,
  `palaute` varchar(500) NOT NULL,
  `aika` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `koetiedot`
--

INSERT INTO `koetiedot` (`id`, `etunimi`, `sukunimi`, `sahkoposti`, `kayttaja`, `salasana`, `kurssi`, `tentti`, `kieli`, `palaute`, `aika`) VALUES
(1, 'Katri', 'Lepola', 'lepola.katri@gmail.com', 'katlepol', '123', 'Ohjelmiston tuotantoversi', '26.8.2022', 'JavaS', 'rwrtyw', '2.6.2022 10.24.59'),
(2, 'Matti', 'Meikäläinen', 'mattimeika@posti.fi', 'matmeikä', 'abc123', '', '', '', '', ''),
(5, 'onni', 'onneton', 'ookjdsod', 'onnonnet', '123', '', '', '', '', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `koetiedot`
--
ALTER TABLE `koetiedot`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `koetiedot`
--
ALTER TABLE `koetiedot`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
