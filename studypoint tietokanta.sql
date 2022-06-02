-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 02.06.2022 klo 10:18
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
-- Database: `studypoint`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `admin`
--

CREATE TABLE `admin` (
  `AID` int(11) NOT NULL,
  `kayttaja` varchar(25) NOT NULL,
  `salasana` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `admin`
--

INSERT INTO `admin` (`AID`, `kayttaja`, `salasana`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Rakenne taululle `opiskelija`
--

CREATE TABLE `opiskelija` (
  `Oid` int(11) NOT NULL,
  `etunimi` varchar(25) NOT NULL,
  `sukunimi` varchar(35) NOT NULL,
  `puhelin` varchar(15) NOT NULL,
  `sahkoposti` varchar(35) NOT NULL,
  `lahiosoite` varchar(40) NOT NULL,
  `postitoimipaikka` varchar(20) NOT NULL,
  `postinro` varchar(10) NOT NULL,
  `kayttaja` varchar(10) NOT NULL,
  `salasana` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `opiskelija`
--

INSERT INTO `opiskelija` (`Oid`, `etunimi`, `sukunimi`, `puhelin`, `sahkoposti`, `lahiosoite`, `postitoimipaikka`, `postinro`, `kayttaja`, `salasana`) VALUES
(3, 'Katri', 'Lepola', '0445000853', 'katri.lepola@edu.keuda.fi', 'kauppatie 2 ', 'tuusula', '04300', 'katlepo', 'abc123'),
(6, 'Jyrki', 'Mörönen', '0506778125', 'jyrki.mörönen@miuku.fi', 'kauratie 5', 'Järvenpää', '04400', 'jyrmörö', 'yffovQbxBo'),
(7, 'hannu', 'Hanhi', '1123773', 'hannu.hanhi@organisaatio.duc', 'vaakkutie 5', 'ankkalinna', '011884', 'hanhanh', 'vKZHXyUIDq'),
(8, 'user', 'user', '000', 'on', 'on', 'on', '000', 'useuser', 'user'),
(10, 'julius', 'penala', '050654432', 'julius.penala@miuku.fi', 'kujatie 3', '05888', 'vaajala', 'juliuspena', 'salasana1'),
(11, 'Kimmo', 'Kiljunen', '0607642801', 'kimmo.kiljunen@sahkoposti.fi', 'postitie3', 'postila', '05600', 'onon', 'onon');

-- --------------------------------------------------------

--
-- Rakenne taululle `palaute`
--

CREATE TABLE `palaute` (
  `Oid` int(11) NOT NULL,
  `etunimi` varchar(25) NOT NULL,
  `sukunimi` varchar(35) NOT NULL,
  `email` varchar(30) NOT NULL,
  `viesti` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `palaute`
--

INSERT INTO `palaute` (`Oid`, `etunimi`, `sukunimi`, `email`, `viesti`) VALUES
(2, 'elmeri', 'elli', 'elmeri.elli@sahko.fi', 'tämä on kokeilu, tämä on kokeilu, tämä on kokeilu, tämä on kokeilu, tämä on kokeilu, tämä on kokeilu, tämä on kokeilu, tämä on kokeilu,  tämä on kokeilu, tämä on kokeilu, '),
(5, 'Esa', 'Kesämies', 'kesäesa@posti.fi', 'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop p');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`AID`);

--
-- Indexes for table `opiskelija`
--
ALTER TABLE `opiskelija`
  ADD PRIMARY KEY (`Oid`);

--
-- Indexes for table `palaute`
--
ALTER TABLE `palaute`
  ADD PRIMARY KEY (`Oid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `AID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `opiskelija`
--
ALTER TABLE `opiskelija`
  MODIFY `Oid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `palaute`
--
ALTER TABLE `palaute`
  MODIFY `Oid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
