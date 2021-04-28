-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 28 Apr 2021 pada 18.02
-- Versi Server: 10.1.9-MariaDB
-- PHP Version: 5.6.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gatedb`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbdiary`
--

CREATE TABLE `tbdiary` (
  `dId` int(11) NOT NULL,
  `dTitle` varchar(50) NOT NULL,
  `dDate` date NOT NULL,
  `dContent` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbhari`
--

CREATE TABLE `tbhari` (
  `h_Id` int(10) NOT NULL,
  `h_title` varchar(50) NOT NULL,
  `h_content` varchar(50) NOT NULL,
  `h_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbhari`
--

INSERT INTO `tbhari` (`h_Id`, `h_title`, `h_content`, `h_date`) VALUES
(1, 'My Birthday', 'Hari saya dilahirkan :)', '2001-11-22');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbkbudha`
--

CREATE TABLE `tbkbudha` (
  `kb_Id` int(10) NOT NULL,
  `kb_name` varchar(50) NOT NULL,
  `kb_location` varchar(50) NOT NULL,
  `kb_year` int(10) NOT NULL,
  `lb_founder` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbkhindu`
--

CREATE TABLE `tbkhindu` (
  `kh_Id` int(10) NOT NULL,
  `kh_name` varchar(50) NOT NULL,
  `kh_location` varchar(50) NOT NULL,
  `kh_year` int(10) NOT NULL,
  `kh_founder` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbkislam`
--

CREATE TABLE `tbkislam` (
  `ki_Id` int(10) NOT NULL,
  `ki_name` varchar(50) NOT NULL,
  `ki_location` varchar(50) NOT NULL,
  `ki_year` int(10) NOT NULL,
  `ki_founder` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbdiary`
--
ALTER TABLE `tbdiary`
  ADD PRIMARY KEY (`dId`);

--
-- Indexes for table `tbhari`
--
ALTER TABLE `tbhari`
  ADD PRIMARY KEY (`h_Id`);

--
-- Indexes for table `tbkbudha`
--
ALTER TABLE `tbkbudha`
  ADD PRIMARY KEY (`kb_Id`);

--
-- Indexes for table `tbkhindu`
--
ALTER TABLE `tbkhindu`
  ADD PRIMARY KEY (`kh_Id`);

--
-- Indexes for table `tbkislam`
--
ALTER TABLE `tbkislam`
  ADD PRIMARY KEY (`ki_Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbdiary`
--
ALTER TABLE `tbdiary`
  MODIFY `dId` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbhari`
--
ALTER TABLE `tbhari`
  MODIFY `h_Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbkbudha`
--
ALTER TABLE `tbkbudha`
  MODIFY `kb_Id` int(10) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbkhindu`
--
ALTER TABLE `tbkhindu`
  MODIFY `kh_Id` int(10) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbkislam`
--
ALTER TABLE `tbkislam`
  MODIFY `ki_Id` int(10) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
