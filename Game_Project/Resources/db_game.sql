-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 07, 2022 at 06:17 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_game`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_leaderboard`
--

CREATE TABLE `tb_leaderboard` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `speed` int(11) NOT NULL,
  `score` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_leaderboard`
--

INSERT INTO `tb_leaderboard` (`id`, `username`, `speed`, `score`) VALUES
(1, 'adasd', 1, 186),
(2, 'dian', 2, 690),
(3, 'adie', 3, 1447),
(4, 'qqqq', 1, 452),
(5, 'addddddd', 3, 1211),
(6, 'adasdadasdasd', 5, 2152),
(7, 'adasd', 3, 1217),
(8, 'dddddddddddddddddd', 2, 677),
(9, 'dddddddddddddddddd', 1, 192),
(10, 'asdasd', 1, 448),
(11, 'd', 2, 877),
(12, 'dddds', 3, 1238),
(13, 'sdddf', 1, 447),
(14, 'f', 3, 1350),
(15, 'firmansyah', 2, 575);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_leaderboard`
--
ALTER TABLE `tb_leaderboard`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_leaderboard`
--
ALTER TABLE `tb_leaderboard`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
