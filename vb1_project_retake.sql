-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Mar 04, 2024 at 04:25 AM
-- Server version: 5.7.36
-- PHP Version: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vb1_project_retake`
--

-- --------------------------------------------------------

--
-- Table structure for table `casts`
--

DROP TABLE IF EXISTS `casts`;
CREATE TABLE IF NOT EXISTS `casts` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Cast_1` varchar(255) NOT NULL,
  `Cast_2` varchar(255) NOT NULL,
  `Cast_3` varchar(255) NOT NULL,
  `Cast_4` varchar(255) NOT NULL,
  `Cast_5` varchar(255) NOT NULL,
  `Movie_id` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `Movie_id` (`Movie_id`)
) ENGINE=MyISAM AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `casts`
--

INSERT INTO `casts` (`ID`, `Cast_1`, `Cast_2`, `Cast_3`, `Cast_4`, `Cast_5`, `Movie_id`) VALUES
(1, 'Robert Downey Jr as Tony Stark', 'Gwyneth Paltrow as Pepper Potts', 'Terrence Howard as Col. James Rhodey', 'Jeff Bridges as Obadiah Stane', 'Clark Gregg as Agent Coulson', 1),
(2, 'Edward Norton as Bruce Banner', 'Liv Tyler as Betty Ross', 'Tim Roth as Emil Blonsky', 'William Hurt as General Thunderbolt', 'Tim Blake Nelson as Samuel Sterns', 2),
(3, 'Robert Downey Jr as Tony Stark', 'Mickey Rourke as Ivan Vanko', 'Gwyneth Paltrow as Pepper Potts', 'Don Cheadle as Col. James Rhodey', 'Scarlett Johansson as Natalie Rushman', 3),
(4, 'Chris Hemsworth as Thor', 'Anthony Hopkins as Odin', 'Natalie Portman as Jane Foster', 'Tom Hiddleston as Loki', 'Stellan Skarsgard as Erik Selvig', 4),
(5, 'Chris Evans as Steve Rogers', 'Hugo Weaving as Johann Schmidt', 'Samuel L. Jackson as Nick Fury', 'Hayley Atwell as Peggy Carter', 'Sebastian Stan as Bucky Barnes', 5),
(6, 'Robert Downey Jr. as Tony Stark', 'Chris Evans as Steve Rogers', 'Chris Hemsworth as Thor', 'Scarlett Johansson as Natasha Romanoff', 'Jeremy Renner as Clint Barton', 6),
(7, 'Robert Downey Jr. as Tony Stark', 'Guy Pearce as Aldrich Killian', 'Gwyneth Paltrow as Pepper Potts', 'Don Cheadle as Col. James Rhodes', 'Rebecca Hall as Maya Hansen', 7),
(8, 'Chris Hemwsworth as Thor', 'Natalie Portman as Jane Foster', 'Tim Hiddleston as Loki', 'Christopher Eccleston as Malekith', 'Anthony Hopkins as Odin', 8),
(9, 'Chris Evans as Steve Rogers', 'Robert Downey Jr. as Tony Stark', 'Scarlett Johansson as Natasha Romanoff', 'Sebastian Stan as Bucky Barnes', 'Anthony Mackie as Sam Wilson', 13),
(10, 'Chris Evans as Steve Rogers', 'Samuel L. Jackson as Nick Fury', 'Scarlett Johansson as Natasha Romanoff', 'Sebastian Stan as Bucky Barnes', 'Anthony Mackie as Sam Wilson', 9),
(11, 'Chris Pratt as Peter Quill', 'Vind Diesel as Groot', 'Bradley Cooper as Rocket', 'Zoe Saldana as Gamora', 'Dave Bautista as Drax', 10),
(12, 'Robert Downey Jr. as Tony Stark', 'Chris Evans as Steve Rogers', 'Scarlett Johansson as Natasha Romanoff', 'Chris Hemsworth as Thor', 'James Spader as Ultron', 11),
(13, 'Paul Rudd as Scott Lang', 'Michael Douglas as Dr. Hank Pym', 'Corey Stoll as Darren Cross', 'Evangeline Lilly as Hope Van Dyne', 'Anthony Mackie as Sam Wilson', 12),
(14, 'Paul Rudd as Scott Lang', 'Evangeline Lilly as Hope Van Dyne', 'Michael Douglas as Dr. Hank Pym', 'Hannah John-Kamen as Ava', 'Walton Goggins as Sonny Burch', 20),
(15, 'Benedict Cumberbatch as Dr. Stephen Strange', 'Chiwetel Ejiofor as Mordo', 'Tilda Swinton as The Ancient One', 'Benedict Wong as Wong', 'Mads Mikkelsen as Kaecilius', 14),
(16, 'Chris Pratt as Peter Quill', 'Zoe Saldana as Gamora', 'Kurt Russell as Ego', 'Michael Rooker as Yondu', 'Karen Gillan as Nebula', 15),
(17, 'Tom Holland as Peter Parker', 'Michael Keaton as Adrian Toomes', 'Robert Downey Jr. as Tony Stark', 'Zendaya as Michelle', 'Jon Favreau as Happy Hogan', 16),
(18, 'Chris Hemwsworth as Thor', 'Tim Hiddleston as Loki', 'Cate Blanchett as Hela', 'Mark Ruffalo as Bruce Banner', 'Tessa Thompson as Valkyrie', 17),
(19, 'Chadwick Boseman as T`Challa', 'Michael B. Jordan as Erik Killmonger', 'Lupita Nyong`o as Nakia', 'Danai Gurira as Okoye', 'Martin Freeman as Everett K. Ross', 18),
(20, 'Robert Downey Jr. as Tony Stark', 'Chris Hemsworth as Thor', 'Chris Evans as Steve Rogers', 'Mark Ruffalo as Bruce Banner', 'Josh Brolin as Thanos', 19);

-- --------------------------------------------------------

--
-- Table structure for table `movies`
--

DROP TABLE IF EXISTS `movies`;
CREATE TABLE IF NOT EXISTS `movies` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(255) NOT NULL,
  `Year` int(11) NOT NULL,
  `Rating` decimal(10,1) NOT NULL DEFAULT '0.0',
  `Rated` varchar(255) NOT NULL,
  `Duration` varchar(255) NOT NULL,
  `Genre` varchar(255) NOT NULL,
  `Cast_1` varchar(255) DEFAULT NULL,
  `Cast_2` varchar(255) DEFAULT NULL,
  `Cast_3` varchar(255) DEFAULT NULL,
  `Cast_4` varchar(255) DEFAULT NULL,
  `Cast_5` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `movies`
--

INSERT INTO `movies` (`ID`, `Title`, `Year`, `Rating`, `Rated`, `Duration`, `Genre`, `Cast_1`, `Cast_2`, `Cast_3`, `Cast_4`, `Cast_5`) VALUES
(1, 'Iron Man', 2008, '7.9', 'PG-13', '2h60m', 'Action, Adventure, Sci-Fi,', 'Robert Downey Jr as Tony Stark', 'Gwyneth Paltrow as Pepper Potts', 'Terrence Howard as Col. James Rhodey', 'Jeff Bridges as Obadiah Stane', 'Clark Gregg as Agent Coulson'),
(2, 'The Incredible Hulk', 2008, '6.6', 'PG-13', '1h52m', 'Action, Adventure, Sci-Fi', 'Edward Norton as Bruce Banner', 'Liv Tyler as Betty Ross', 'Tim Roth as Emil Blonsky', 'William Hurt as General Thunderbolt', 'Tim Blake Nelson as Samuel Sterns'),
(3, 'Iron Man 2', 2010, '6.9', 'PG-13', '2h4m', 'Action, Adventure, Sci-Fi', 'Robert Downey Jr as Tony Stark', 'Mickey Rourke as Ivan Vanko', 'Gwyneth Paltrow as Pepper Potts', 'Don Cheadle as Col. James Rhodey', 'Scarlett Johansson as Natalie Rushman'),
(4, 'Thor', 2011, '7.0', 'PG-13', '1h55m', 'Action, Adventure, Fantasy', 'Chris Hemsworth as Thor', 'Anthony Hopkins as Odin', 'Natalie Portman as Jane Foster', 'Tom Hiddleston as Loki', 'Stellan Skarsgard as Erik Selvig'),
(5, 'Captain America: The First Avenger', 2011, '6.9', 'PG-13', '2h4m', 'Action, Adventure, Sci-Fi', 'Chris Evans as Steve Rogers', 'Hugo Weaving as Johann Schmidt', 'Samuel L. Jackson as Nick Fury', 'Hayley Atwell as Peggy Carter', 'Sebastian Stan as Bucky Barnes'),
(6, 'The Avengers', 2012, '8.0', 'PG-13', '2h23m', 'Action, Adventure, Sci-Fi', 'Robert Downey Jr. as Tony Stark', 'Chris Evans as Steve Rogers', 'Chris Hemsworth as Thor', 'Scarlett Johansson as Natasha Romanoff', 'Jeremy Renner as Clint Barton'),
(7, 'Iron Man 3', 2013, '7.1', 'PG-13', '2h10m', 'Action, Adventure, Sci-Fi', 'Robert Downey Jr. as Tony Stark', 'Guy Pearce as Aldrich Killian', 'Gwyneth Paltrow as Pepper Potts', 'Don Cheadle as Col. James Rhodes', 'Rebecca Hall as Maya Hansen'),
(8, 'Thor: The Dark World', 2013, '6.8', 'PG-13', '1h52m', 'Action, Adventure, Fantasy', 'Chris Hemwsworth as Thor', 'Natalie Portman as Jane Foster', 'Tim Hiddleston as Loki', 'Christopher Eccleston as Malekith', 'Anthony Hopkins as Odin'),
(9, 'Captain America: The Winter Soldier', 2014, '7.8', 'PG-13', '2h16m', 'Action, Adventure, Sci-Fi', 'Chris Evans as Steve Rogers', 'Samuel L. Jackson as Nick Fury', 'Scarlett Johansson as Natasha Romanoff', 'Sebastian Stan as Bucky Barnes', 'Anthony Mackie as Sam Wilson'),
(10, 'Guardians of the Galaxy', 2014, '8.0', 'PG-13', '2h1m', 'Action, Adventure, Comedy', 'Chris Pratt as Peter Quill', 'Vind Diesel as Groot', 'Bradley Cooper as Rocket', 'Zoe Saldana as Gamora', 'Dave Bautista as Drax'),
(11, 'Avengers: Age of Ultron', 2015, '7.3', 'PG-13', '2h21m', 'Action, Adventure, Sci-Fi', 'Robert Downey Jr. as Tony Stark', 'Chris Evans as Steve Rogers', 'Scarlett Johansson as Natasha Romanoff', 'Chris Hemsworth as Thor', 'James Spader as Ultron'),
(12, 'Ant-Man', 2015, '7.3', 'PG-13', '1h57m', 'Action, Adventure, Comedy', 'Paul Rudd as Scott Lang', 'Michael Douglas as Dr. Hank Pym', 'Corey Stoll as Darren Cross', 'Evangeline Lilly as Hope Van Dyne', 'Anthony Mackie as Sam Wilson'),
(13, 'Captain America: Civil War', 2016, '7.8', 'PG-13', '2h27m', 'Action, Adventure, Sci-Fi', 'Chris Evans as Steve Rogers', 'Robert Downey Jr. as Tony Stark', 'Scarlett Johansson as Natasha Romanoff', 'Sebastian Stan as Bucky Barnes', 'Anthony Mackie as Sam Wilson'),
(14, 'Doctor Strange', 2016, '7.5', 'PG-13', '1h55m', 'Action, Adventure, Fantasy', 'Benedict Cumberbatch as Dr. Stephen Strange', 'Chiwetel Ejiofor as Mordo', 'Tilda Swinton as The Ancient One', 'Benedict Wong as Wong', 'Mads Mikkelsen as Kaecilius'),
(15, 'Guardians of the Galaxy Vol. 2', 2017, '7.6', 'PG-13', '2h16m', 'Action, Adventure, Comedy, ', 'Chris Pratt as Peter Quill', 'Zoe Saldana as Gamora', 'Kurt Russell as Ego', 'Michael Rooker as Yondu', 'Michael Rooker as Yondu'),
(16, 'Spider-Man: Homecoming', 2017, '7.4', 'PG-13', '2h13m', 'Action, Adventure, Sci-Fi', 'Tom Holland as Peter Parker', 'Michael Keaton as Adrian Toomes', 'Robert Downey Jr. as Tony Stark', 'Zendaya as Michelle', 'Jon Favreau as Happy Hogan'),
(17, 'Thor: Ragnarok', 2017, '7.9', 'PG-13', '2h10m', 'Action, Adventure, Comedy', 'Chris Hemwsworth as Thor', 'Tim Hiddleston as Loki', 'Cate Blanchett as Hela', 'Cate Blanchett as Hela', 'Tessa Thompson as Valkyrie'),
(18, 'Black Panther', 2018, '7.3', 'PG-13', '2h14m', 'Action, Adventure, Sci-Fi', 'Chadwick Boseman as T`Challa', 'Michael B. Jordan as Erik Killmonger', 'Michael B. Jordan as Erik Killmonger', 'Danai Gurira as Okoye', 'Martin Freeman as Everett K. Ross'),
(19, 'Avengers: Infinity War', 2018, '8.4', 'PG-13', '2h29m', 'Action, Adventure, Sci-Fi', 'Robert Downey Jr. as Tony Stark', 'Chris Hemsworth as Thor', 'Chris Evans as Steve Rogers', 'Mark Ruffalo as Bruce Banner', 'Josh Brolin as Thanos'),
(20, 'Ant-Man and the Wasp', 2018, '7.0', 'PG-13', '2h1m', 'Action, Adventure, Comedy', 'Paul Rudd as Scott Lang', 'Evangeline Lilly as Hope Van Dyne', 'Michael Douglas as Dr. Hank Pym', 'Hannah John-Kamen as Ava', 'Walton Goggins as Sonny Burch');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Firstname` varchar(255) NOT NULL,
  `Lastname` varchar(255) NOT NULL,
  `Age` int(11) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Telephone` varchar(255) NOT NULL,
  `Level` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`ID`, `Username`, `Password`, `Firstname`, `Lastname`, `Age`, `Address`, `Telephone`, `Level`) VALUES
(1, 'master', 'admin', 'master', 'admin', 25, '12 avenue street, montreal, qc', '514-123-1234', 1),
(2, 'kevin1', 'kevin1', 'kevin', 'chan', 25, '12 saturne, montreal, qc', '514-123-1234', 0),
(3, 'kenton', 'kenton', 'ken', 'lam', 35, '432 rainbow, markham, on', '436-334-8899', 0),
(4, 'michael2', 'michael2', 'michael', 'jordan', 32, '23 avenue laurier, montreal, qc', '514-555-0090', 0),
(8, 'admin', 'admin', 'admin', 'admin', 26, '123 admini', '123-123-1234', 0),
(9, 'sub', 'sub', 'sub', 'sub', 18, '123 sub', '213-123-1233', 1),
(11, 'asd', 'asd', 'asd', 'asd', 23, '123 asd', '123-123-1234', 0);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
