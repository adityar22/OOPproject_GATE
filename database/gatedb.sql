-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 09 Jun 2021 pada 03.48
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
(3, 'Hari ini', '2021-06-08', 'aku ngoding dan ngoding terus ngoding'),
(4, 'anu', '2021-06-08', 'begini'),
(5, 'huwaaaa', '2021-06-08', 'hublaaaaaa'),
(6, 'kenapa', '2021-06-08', 'aku pusinggg'),
(7, 'Hari Ini', '2021-06-09', 'Aku Bahagia yeyyy'),
(8, 'besok hari', '2021-06-09', 'adalah lusanya kemarin');

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
(1, 'My Birthday', 'Hari saya dilahirkan :)', '2001-11-22'),
(2, 'Hubla', 'hubla wumbo jumbo', '2001-11-22'),
(3, 'anuu', 'ituuu', '2021-03-03'),
(4, 'petualang', 'lalalalala', '2022-02-02'),
(5, 'to the moon', 'explore the sky', '2001-11-22');

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
-- Dumping data untuk tabel `tbuser`
--

INSERT INTO `tbuser` (`username`, `password`, `firstname`, `lastname`, `email`, `birth`, `level`) VALUES
('adit', 'adit', 'aditya', 'ra', 'adit@gmail.com', '2001-11-22', 0),
('aditya22', 'raven2112', 'Aditya', 'Ramadhan', 'adit.rpl12@gmail.com', '2001-11-22', 0),
('adityr', 'raveluna03', 'Aditya', 'Ramadhan', 'adit.rpl2112@gmail.com', '2001-11-22', 0),
('adityram', 'raveluna03', 'Aditya', 'Ramadhan', 'adit.rpl03@gmail.com', '2001-11-22', 0),
('aku', 'anu', 'namaku', 'namakuu', 'namaku@gmail.com', '2001-11-11', 0);

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
  MODIFY `dId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `tbhari`
--
ALTER TABLE `tbhari`
  MODIFY `h_Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
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
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
