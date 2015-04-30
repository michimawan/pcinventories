-- phpMyAdmin SQL Dump
-- version 4.1.12
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 10, 2015 at 06:19 AM
-- Server version: 5.6.16
-- PHP Version: 5.5.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `pcinvent`
--

-- --------------------------------------------------------

--
-- Table structure for table `chamber`
--

CREATE TABLE IF NOT EXISTS `chamber` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `namechamber` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `pcs`
--

CREATE TABLE IF NOT EXISTS `pcs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `proc` varchar(100) NOT NULL,
  `hdd` varchar(100) NOT NULL,
  `ram` varchar(100) NOT NULL,
  `vga` varchar(100) NOT NULL,
  `os` varchar(100) NOT NULL,
  `owner` varchar(100) NOT NULL,
  `room` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `room` (`room`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `staffpuspel`
--

CREATE TABLE IF NOT EXISTS `staffpuspel` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `names` varchar(100) NOT NULL,
  `staffname` varchar(100) NOT NULL,
  `staffpass` varchar(500) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `staffpuspel`
--

INSERT INTO `staffpuspel` (`id`, `names`, `staffname`, `staffpass`) VALUES
(1, 'Himawan', 'awan', '14AE3694F13F4FB0F9D29C39934C6BE1B1DB4A58E3569C773C759B96297F1'),
(4, 'meme', 'memes', '6A35BD9B4AB19F46C917781896A0D9A1CC66941707EC0E4F7C2F11BEE8B6F52');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `pcs`
--
ALTER TABLE `pcs`
  ADD CONSTRAINT `pcs_ibfk_1` FOREIGN KEY (`room`) REFERENCES `chamber` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
