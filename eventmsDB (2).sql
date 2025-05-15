-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 30, 2024 at 06:41 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `eventms`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `tp` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `name`, `password`, `email`, `tp`) VALUES
(1, 'admin', 'admin123', 'jdyfsgbdcjdhsad', '546372653');

-- --------------------------------------------------------

--
-- Table structure for table `bookedevents`
--

CREATE TABLE `bookedevents` (
  `bookingid` int(11) NOT NULL,
  `eventid` int(11) NOT NULL,
  `memberid` int(11) NOT NULL,
  `eventname` varchar(255) DEFAULT NULL,
  `eventtype` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bookedevents`
--

INSERT INTO `bookedevents` (`bookingid`, `eventid`, `memberid`, `eventname`, `eventtype`) VALUES
(55, 6, 1, 'Green Room', 'Music'),
(60, 6, 7, 'Green Room', 'Music');

-- --------------------------------------------------------

--
-- Table structure for table `manageevents`
--

CREATE TABLE `manageevents` (
  `eventid` int(11) NOT NULL,
  `eventtype` varchar(255) NOT NULL,
  `eventvenue` varchar(255) NOT NULL,
  `ticketprice` varchar(255) NOT NULL,
  `ticketsavailable` int(11) DEFAULT 1500,
  `eventname` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `manageevents`
--

INSERT INTO `manageevents` (`eventid`, `eventtype`, `eventvenue`, `ticketprice`, `ticketsavailable`, `eventname`) VALUES
(6, 'Lotus tower ', 'Music', '2000', 1488, 'Green Room');

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `tp` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`id`, `name`, `password`, `email`, `tp`) VALUES
(1, 'angelo', 'angelo123', 'djsgfdh', 56473829),
(4, 'dilan', 'dilan123', 'skahud', 46378),
(6, 'chathushi', 'chathushi123', 'uasgjyf', 546372819),
(7, 'dillon', 'dillon123', 'idayfhbkjd', 546378);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `bookedevents`
--
ALTER TABLE `bookedevents`
  ADD PRIMARY KEY (`bookingid`),
  ADD KEY `eventid` (`eventid`),
  ADD KEY `memberid` (`memberid`);

--
-- Indexes for table `manageevents`
--
ALTER TABLE `manageevents`
  ADD PRIMARY KEY (`eventid`);

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=79;

--
-- AUTO_INCREMENT for table `bookedevents`
--
ALTER TABLE `bookedevents`
  MODIFY `bookingid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=65;

--
-- AUTO_INCREMENT for table `manageevents`
--
ALTER TABLE `manageevents`
  MODIFY `eventid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `member`
--
ALTER TABLE `member`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=67;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `bookedevents`
--
ALTER TABLE `bookedevents`
  ADD CONSTRAINT `bookedevents_ibfk_1` FOREIGN KEY (`eventid`) REFERENCES `manageevents` (`eventid`) ON DELETE CASCADE,
  ADD CONSTRAINT `bookedevents_ibfk_2` FOREIGN KEY (`memberid`) REFERENCES `member` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
