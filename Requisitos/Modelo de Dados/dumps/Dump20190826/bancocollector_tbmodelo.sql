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
-- Table structure for table `tbmodelo`
--

DROP TABLE IF EXISTS `tbmodelo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbmodelo` (
  `codModelo` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `quantTiragem` varchar(45) DEFAULT NULL,
  `colecao` varchar(45) DEFAULT NULL,
  `label` varchar(45) DEFAULT NULL,
  `marca` varchar(45) DEFAULT NULL,
  `ano` varchar(4) DEFAULT NULL,
  `edicao` varchar(45) DEFAULT NULL,
  `roteirista` varchar(45) DEFAULT NULL,
  `desenhista` varchar(45) DEFAULT NULL,
  `isbn` varchar(13) DEFAULT NULL,
  `autor` varchar(45) DEFAULT NULL,
  `codSubcategoria` int(11) NOT NULL,
  `TbUsuario_codUsuario` int(11) NOT NULL,
  PRIMARY KEY (`codModelo`),
  KEY `fk_TbModelo_TbSubcategoria1_idx` (`codSubcategoria`),
  KEY `fk_TbModelo_TbUsuario1_idx` (`TbUsuario_codUsuario`),
  CONSTRAINT `fk_TbModelo_TbSubcategoria1` FOREIGN KEY (`codSubcategoria`) REFERENCES `tbsubcategoria` (`codSubcategoria`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TbModelo_TbUsuario1` FOREIGN KEY (`TbUsuario_codUsuario`) REFERENCES `tbusuario` (`codUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbmodelo`
--

LOCK TABLES `tbmodelo` WRITE;
/*!40000 ALTER TABLE `tbmodelo` DISABLE KEYS */;
INSERT INTO `tbmodelo` VALUES (2,'Hotwheels','2000','bike','dasda','dasdasd','1990',NULL,NULL,NULL,NULL,NULL,1,1);
/*!40000 ALTER TABLE `tbmodelo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-08-26 16:12:18
