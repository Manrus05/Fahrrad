-- MariaDB dump 10.17  Distrib 10.4.6-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: fahrrad
-- ------------------------------------------------------
-- Server version	10.4.6-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

DROP DATABASE fahhrad;
CREATE DATABASE fahrrad;
USE fahrrad;
--
-- Table structure for table `fertigware`
--

DROP TABLE IF EXISTS `fertigware`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fertigware` (
  `fwNr` int(11) NOT NULL AUTO_INCREMENT,
  `fwModell` varchar(200) DEFAULT NULL,
  `fwPreis` decimal(6,2) DEFAULT NULL,
  PRIMARY KEY (`fwNr`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fertigware`
--

LOCK TABLES `fertigware` WRITE;
/*!40000 ALTER TABLE `fertigware` DISABLE KEYS */;
INSERT INTO `fertigware` VALUES (1,'Fahrrad Bigfoot',999.99),(2,'Fahrrad Anfänger',111.11),(3,'Noch ein Fahrrad',500.00),(4,'Und noch eines',2.00);
/*!40000 ALTER TABLE `fertigware` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fwrw`
--

DROP TABLE IF EXISTS `fwrw`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fwrw` (
  `fwrwnr` int(11) NOT NULL AUTO_INCREMENT,
  `fwfk` int(11) DEFAULT NULL,
  `rwfk` int(11) DEFAULT NULL,
  `menge` int(11) DEFAULT NULL,
  PRIMARY KEY (`fwrwnr`),
  KEY `fwfk` (`fwfk`),
  KEY `rwfk` (`rwfk`),
  CONSTRAINT `fwrw_ibfk_1` FOREIGN KEY (`fwfk`) REFERENCES `fertigware` (`fwNr`),
  CONSTRAINT `fwrw_ibfk_2` FOREIGN KEY (`rwfk`) REFERENCES `rohware` (`rwNr`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fwrw`
--

LOCK TABLES `fwrw` WRITE;
/*!40000 ALTER TABLE `fwrw` DISABLE KEYS */;
INSERT INTO `fwrw` VALUES (1,1,1,1),(2,2,2,2),(3,1,2,2),(4,2,3,1),(5,1,3,1),(6,1,3,2),(7,1,3,5),(8,2,2,1);
/*!40000 ALTER TABLE `fwrw` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rohware`
--

DROP TABLE IF EXISTS `rohware`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rohware` (
  `rwNr` int(11) NOT NULL AUTO_INCREMENT,
  `rwBezeichnung` varchar(200) DEFAULT NULL,
  `rwPreis` decimal(6,2) DEFAULT NULL,
  PRIMARY KEY (`rwNr`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rohware`
--

LOCK TABLES `rohware` WRITE;
/*!40000 ALTER TABLE `rohware` DISABLE KEYS */;
INSERT INTO `rohware` VALUES (1,'Schlauch 25 Zoll',1.33),(2,'Lenker nur rechts',22.50),(3,'Sattel unbequem',12.22);
/*!40000 ALTER TABLE `rohware` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `vfwrw`
--

DROP TABLE IF EXISTS `vfwrw`;
/*!50001 DROP VIEW IF EXISTS `vfwrw`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `vfwrw` (
  `fwfk` tinyint NOT NULL,
  `menge` tinyint NOT NULL,
  `rwbezeichnung` tinyint NOT NULL,
  `rwPreis` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vfwrw`
--

/*!50001 DROP TABLE IF EXISTS `vfwrw`*/;
/*!50001 DROP VIEW IF EXISTS `vfwrw`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vfwrw` AS select `fwrw`.`fwfk` AS `fwfk`,`fwrw`.`menge` AS `menge`,`rohware`.`rwBezeichnung` AS `rwbezeichnung`,`rohware`.`rwPreis` AS `rwPreis` from (`fwrw` join `rohware`) where `fwrw`.`rwfk` = `rohware`.`rwNr` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-01-11 15:16:02
