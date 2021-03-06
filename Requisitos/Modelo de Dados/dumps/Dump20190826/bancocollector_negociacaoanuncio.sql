CREATE DATABASE  IF NOT EXISTS `bancocollector` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `bancocollector`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: bancocollector
-- ------------------------------------------------------
-- Server version	5.5.62

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `negociacaoanuncio`
--

DROP TABLE IF EXISTS `negociacaoanuncio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `negociacaoanuncio` (
  `codNegociacao` int(11) NOT NULL,
  `codAnuncio` int(11) NOT NULL,
  PRIMARY KEY (`codNegociacao`,`codAnuncio`),
  KEY `fk_TbNegociacao_has_TbAnuncio_TbAnuncio1_idx` (`codAnuncio`),
  KEY `fk_TbNegociacao_has_TbAnuncio_TbNegociacao1_idx` (`codNegociacao`),
  CONSTRAINT `fk_TbNegociacao_has_TbAnuncio_TbAnuncio1` FOREIGN KEY (`codAnuncio`) REFERENCES `tbanuncio` (`codAnuncio`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TbNegociacao_has_TbAnuncio_TbNegociacao1` FOREIGN KEY (`codNegociacao`) REFERENCES `tbnegociacao` (`codNegociacao`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `negociacaoanuncio`
--

LOCK TABLES `negociacaoanuncio` WRITE;
/*!40000 ALTER TABLE `negociacaoanuncio` DISABLE KEYS */;
/*!40000 ALTER TABLE `negociacaoanuncio` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-08-26 16:12:33
