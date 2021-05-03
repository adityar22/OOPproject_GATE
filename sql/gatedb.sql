-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 03 Mei 2021 pada 09.01
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

--
-- Dumping data untuk tabel `tbdiary`
--

INSERT INTO `tbdiary` (`dId`, `dTitle`, `dDate`, `dContent`) VALUES
(1, 'Hariku', '2001-01-01', 'cerah'),
(2, 'Hari ini', '2001-01-01', 'dyjtd.ysdky,fh,fkuydghdh');

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
  `kId` int(10) NOT NULL,
  `kName` varchar(50) NOT NULL,
  `kLocation` varchar(50) NOT NULL,
  `kYear` int(10) NOT NULL,
  `kFounder` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbkhindu`
--

CREATE TABLE `tbkhindu` (
  `kId` int(10) NOT NULL,
  `kName` varchar(50) NOT NULL,
  `kLocation` varchar(50) NOT NULL,
  `kYear` int(10) NOT NULL,
  `kFounder` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbkislam`
--

CREATE TABLE `tbkislam` (
  `kId` int(10) NOT NULL,
  `kName` varchar(50) NOT NULL,
  `kLocation` varchar(50) NOT NULL,
  `kYear` int(10) NOT NULL,
  `kFounder` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbraja`
--

CREATE TABLE `tbraja` (
  `tId` int(11) NOT NULL,
  `tName` varchar(50) NOT NULL,
  `tKingdom` varchar(50) NOT NULL,
  `tBirth` int(10) NOT NULL,
  `tDie` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbuser`
--

CREATE TABLE `tbuser` (
  `username` varchar(25) NOT NULL,
  `password` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `birth` date NOT NULL,
  `level` int(3) NOT NULL
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
  ADD PRIMARY KEY (`kId`);

--
-- Indexes for table `tbkhindu`
--
ALTER TABLE `tbkhindu`
  ADD PRIMARY KEY (`kId`);

--
-- Indexes for table `tbkislam`
--
ALTER TABLE `tbkislam`
  ADD PRIMARY KEY (`kId`);

--
-- Indexes for table `tbraja`
--
ALTER TABLE `tbraja`
  ADD PRIMARY KEY (`tId`);

--
-- Indexes for table `tbuser`
--
ALTER TABLE `tbuser`
  ADD PRIMARY KEY (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbdiary`
--
ALTER TABLE `tbdiary`
  MODIFY `dId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbhari`
--
ALTER TABLE `tbhari`
  MODIFY `h_Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbkbudha`
--
ALTER TABLE `tbkbudha`
  MODIFY `kId` int(10) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbkhindu`
--
ALTER TABLE `tbkhindu`
  MODIFY `kId` int(10) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbkislam`
--
ALTER TABLE `tbkislam`
  MODIFY `kId` int(10) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbraja`
--
ALTER TABLE `tbraja`
  MODIFY `tId` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
