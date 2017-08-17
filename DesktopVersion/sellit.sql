-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 17, 2017 at 06:11 PM
-- Server version: 10.1.25-MariaDB
-- PHP Version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
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
-- Table structure for table `customer_info`
--

CREATE TABLE `customer_info` (
  `cus_id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `address` varchar(200) NOT NULL,
  `phone_no` varchar(50) NOT NULL,
  `bonus_point` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer_info`
--

INSERT INTO `customer_info` (`cus_id`, `name`, `email`, `password`, `address`, `phone_no`, `bonus_point`) VALUES
(1, 'asif', 'asifisthiaq@gmail.com', '12345', 'Kushtia', '01770600667', '2'),
(2, 'anik', 'anik@gmail.com', '123456', 'Basabo', '000000000', '5'),
(3, 'Jarif', 'jarif@gmail.com', '1234', 'Dhaka', '12345', '0'),
(4, 'aaaa', 'a@gmail.com', '12345', 'aaaa', '12345', '0'),
(6, 'conor', 'a2@gmail.com', '1', 'a', '11', '0'),
(7, 'a3', 'a3@gmail.com', '1', 'aaa', '12345', '0');

-- --------------------------------------------------------

--
-- Table structure for table `order_tbl`
--

CREATE TABLE `order_tbl` (
  `order_id` int(11) NOT NULL,
  `cus_name` varchar(50) NOT NULL,
  `address` varchar(50) NOT NULL,
  `phn_no` varchar(50) NOT NULL,
  `item_name` varchar(1000) NOT NULL,
  `item_quan` varchar(1000) NOT NULL,
  `amount` varchar(50) NOT NULL,
  `vat` varchar(50) NOT NULL,
  `total_amount` varchar(50) NOT NULL,
  `delivered` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `order_tbl`
--

INSERT INTO `order_tbl` (`order_id`, `cus_name`, `address`, `phn_no`, `item_name`, `item_quan`, `amount`, `vat`, `total_amount`, `delivered`) VALUES
(2, 'conor', 'a', '11', 'COCA-COLA Soft Drink Can (24 x 200 ml),Mars candy Bar,Langers Apple Mango,', '3,2,1,', '1480', '236', '1716', 'NO'),
(5, 'conor', 'a', '11', 'Snickers Box of 24 pcs,COCA-COLA Soft Drink Can (24 x 200 ml),Ferrero Rocher,', '1,1,1,', '2350', '572.5', '2922.5', 'NO'),
(6, 'conor', 'a', '11', 'COCA-COLA Soft Drink Can (24 x 200 ml),', '3,', '450', '67.5', '517.5', 'NO'),
(7, 'conor', 'a', '11', 'Red Bull,', '2,', '370', '55.5', '425.5', 'NO'),
(8, 'conor', 'a', '11', 'Cadbury Dairy Milk Silk,', '2,', '800', '200', '1000', 'NO'),
(9, 'conor', 'a', '11', 'Ferrero Rocher,COCA-COLA Soft Drink Can (24 x 200 ml),Cadbury Dairy Milk Silk,', '3,4,2,', '3050', '702.5', '3752.5', 'NO');

-- --------------------------------------------------------

--
-- Table structure for table `sell_tbl`
--

CREATE TABLE `sell_tbl` (
  `sell_id` int(11) NOT NULL,
  `products` varchar(50) NOT NULL,
  `quantity` varchar(50) NOT NULL,
  `amount` varchar(50) NOT NULL,
  `vat` varchar(50) NOT NULL,
  `totalAmount` varchar(50) NOT NULL,
  `dateTime` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sell_tbl`
--

INSERT INTO `sell_tbl` (`sell_id`, `products`, `quantity`, `amount`, `vat`, `totalAmount`, `dateTime`) VALUES
(1, '140204010,140204007,', '2,1,', '155', '25.9', '180.9', '06:45:10\n10/08/2017'),
(2, '140204009,', '4,', '720', '129.6', '849.6', '06:50:46\n10/08/2017'),
(3, '140204005,', '2,', '2100', '210', '2310', '06:56:12\n10/08/2017'),
(4, '140204006,', '2,', '930', '93', '1023', '07:04:53\n10/08/2017'),
(5, '140204027,', '2,', '114', '11.4', '125.4', '07:12:58\n10/08/2017'),
(6, '140204002,', '1,', '420', '42', '462', '07:15:26\n10/08/2017'),
(7, '140204010,140204009,', '1,1,', '245', '44.1', '289.1', '07:16:26\n10/08/2017'),
(8, '140204007,', '1,', '25', '2.5', '27.5', '07:17:54\n10/08/2017'),
(9, '140204006,140204005,', '2,1,', '1980', '198', '2178', '09:38:07\n10/08/2017');

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
(1, 'Ifad Choco Delight Biscuit', 53, 57, 53, 'Snacks', '300gm', '140204027'),
(3, 'Pringles can', 5, 420, 350, 'Snacks', '160gm', '140204002'),
(5, 'Igloo chocolate ice cream', 10, 550, 500, 'dairy', '1liter', '140204004'),
(6, 'Lingo tin pack assorted buiscuits', 2, 1050, 950, 'Snacks', '800gm', '140204005'),
(7, 'lays', 8, 465, 400, 'Snacks', '350gm', '140204006'),
(8, 'All time chocolate cake', 28, 25, 20, 'Snacks', '350gm', '140204007'),
(14, 'Pran hot tomato sauce', 15, 180, 140, 'grocery', '1kg', '140204009'),
(15, 'Aci pure atta', 12, 65, 50, 'grocery', '2kg', '140204010'),
(16, 'Alfa mayonnaise', 7, 180, 150, 'dairy', '480ml', '140204011'),
(17, 'Aarong pure ghee ', 6, 450, 400, 'dairy', '400gm', '140204012'),
(18, 'Diploma milk powder ', 8, 240, 200, 'dairy', '400gm', '140204013'),
(24, 'Aarong butter', 11, 90, 60, 'dairy', '100gm', '140204014'),
(27, 'Cadbury Dairy Milk Silk', 7, 400, 300, 'Chocolate', '250gm', '140204058'),
(28, 'Ferrero Rocher', 12, 550, 350, 'Chocolate', '360gm', '140204059'),
(29, 'COCA-COLA Soft Drink Can (24 x 200 ml)', 19, 150, 100, 'beverages', '700gm', '140204060'),
(30, 'Kitkat 2 Fingers 36 Pieces', 9, 2000, 1500, 'Chocolate', '400gm', '140204061'),
(31, 'Snickers Box of 24 pcs', 16, 1650, 1000, 'Chocolate', '500gm', '140204062'),
(32, 'Mars candy Bar', 48, 70, 50, 'Chocolate', '35gm', '140204063'),
(33, 'Red Bull', 58, 185, 120, 'beverages', '300ml', '140204064'),
(34, 'Langers Apple Mango', 43, 890, 700, 'beverages', '250ml', '140204065');

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
  `age` varchar(50) NOT NULL,
  `address` varchar(150) NOT NULL,
  `phone_no` varchar(50) NOT NULL,
  `salary` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `userinfo`
--

INSERT INTO `userinfo` (`user_id`, `name`, `user_name`, `password`, `account_type`, `age`, `address`, `phone_no`, `salary`) VALUES
(1, 'Anik Chowdhury', 'anik1994', '1234', 'admin', '21', '32,33 North Basaboo, Dhaka-1214', '01942508770', 20),
(2, 'Faiza Omar', 'faiza', '12345', 'cashier', '22', 'Eskaton Road', '0123423456', 50000),
(3, 'a', 'a', '12193117185192241182168491951532261051193897', 'admin', '15', '', '', 30),
(5, 'asif', 'asid', '2251022057731868917119086224872421513662', 'admin', '24', '32,33 modhubagh', '012345', 15000),
(9, 'inzamam', 'inzu', '2251022057731868917119086224872421513662', 'cashier', '23', '25 modhubagh', '123456', 20000);

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
-- Indexes for table `order_tbl`
--
ALTER TABLE `order_tbl`
  ADD PRIMARY KEY (`order_id`);

--
-- Indexes for table `sell_tbl`
--
ALTER TABLE `sell_tbl`
  ADD PRIMARY KEY (`sell_id`);

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
-- AUTO_INCREMENT for table `order_tbl`
--
ALTER TABLE `order_tbl`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `sell_tbl`
--
ALTER TABLE `sell_tbl`
  MODIFY `sell_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `stock`
--
ALTER TABLE `stock`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;
--
-- AUTO_INCREMENT for table `userinfo`
--
ALTER TABLE `userinfo`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
