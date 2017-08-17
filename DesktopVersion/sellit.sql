-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 09, 2017 at 12:28 AM
-- Server version: 10.1.10-MariaDB
-- PHP Version: 5.6.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sellit`
--

-- --------------------------------------------------------

--
-- Table structure for table `stock`
--

CREATE TABLE `stock` (
  `item_id` int(11) NOT NULL,
  `item_name` varchar(50) NOT NULL,
  `rest_item` int(11) NOT NULL,
  `selling_price` double NOT NULL,
  `purhase_price` double NOT NULL,
  `type` varchar(50) NOT NULL,
  `weight` varchar(50) NOT NULL,
  `barcode` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stock`
--

INSERT INTO `stock` (`item_id`, `item_name`, `rest_item`, `selling_price`, `purhase_price`, `type`, `weight`, `barcode`) VALUES
(1, 'Ifad Choco Delight Biscuit', 55, 57, 53, 'Snacks', '300gm', '140204027'),
(2, 'Snickers Chocolate', 35, 42, 38, 'Chocolate', '50gm', '140204001'),
(3, 'Pringles can', 6, 420, 350, 'Snacks', '160gm', '140204002'),
(4, 'Cadbury dairy milk', 20, 160, 100, 'Chocolate', '50gm', '140204003'),
(5, 'Igloo chocolate ice cream', 10, 550, 500, 'dairy', '1liter', '140204004'),
(6, 'Lingo tin pack assorted buiscuits', 5, 1050, 950, 'Snacks', '800gm', '140204005'),
(7, 'lays', 12, 465, 400, 'Snacks', '350gm', '140204006'),
(8, 'All time chocolate cake', 30, 25, 20, 'Snacks', '350gm', '140204007'),
(9, 'Pran zeera pani', 40, 25, 15, 'beverages', '250ml', '140204008'),
(14, 'Pran hot tomato sauce', 20, 180, 140, 'grocery', '1kg', '140204009'),
(15, 'Aci pure atta', 15, 65, 50, 'grocery', '2kg', '140204010'),
(16, 'Alfa mayonnaise', 7, 180, 150, 'dairy', '480ml', '140204011'),
(17, 'Aarong pure ghee ', 6, 450, 400, 'dairy', '400gm', '140204012'),
(18, 'Diploma milk powder ', 8, 240, 200, 'dairy', '400gm', '140204013'),
(24, 'Aarong butter', 11, 90, 60, 'dairy', '100gm', '140204014'),
(25, 'Ispahani mirzapur cha', 30, 170, 130, 'beverages', '400gm', '140204015'),
(26, 'Nescafe coffee ', 13, 300, 250, 'beverages', '100gm', '140204016');

-- --------------------------------------------------------

--
-- Table structure for table `userinfo`
--

CREATE TABLE `userinfo` (
  `user_id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `user_name` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `account_type` varchar(50) NOT NULL,
  `age` int(11) NOT NULL,
  `address` varchar(150) NOT NULL,
  `phone_no` varchar(50) NOT NULL,
  `salary` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `userinfo`
--

INSERT INTO `userinfo` (`user_id`, `name`, `user_name`, `password`, `account_type`, `age`, `address`, `phone_no`, `salary`) VALUES
(1, 'Anik Chowdhury', 'anik1994', '1234', 'admin', 21, '32,33 North Basaboo, Dhaka-1214', '01942508770', 20),
(2, 'Faiza Omar', 'faiza', '12345', 'cashier', 22, 'Eskaton Road', '0123423456', 50000),
(3, 'a', 'a', 'a', 'admin', 0, '', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `vat_informer`
--

CREATE TABLE `vat_informer` (
  `type` varchar(50) NOT NULL,
  `vat` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `vat_informer`
--

INSERT INTO `vat_informer` (`type`, `vat`) VALUES
('beverages', 15),
('Chocolate', 25),
('dairy', 12),
('grocery', 18),
('Snacks', 10);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`item_id`);

--
-- Indexes for table `userinfo`
--
ALTER TABLE `userinfo`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `vat_informer`
--
ALTER TABLE `vat_informer`
  ADD PRIMARY KEY (`type`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `stock`
--
ALTER TABLE `stock`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;
--
-- AUTO_INCREMENT for table `userinfo`
--
ALTER TABLE `userinfo`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
