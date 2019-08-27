-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: bancocollector
-- ------------------------------------------------------
-- Server version	5.5.8

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('00000000000000_CreateIdentitySchema','2.1.11-servicing-32099');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `anunciomodelo`
--

DROP TABLE IF EXISTS `anunciomodelo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `anunciomodelo` (
  `codAnuncio` int(11) NOT NULL,
  `codModelo` int(11) NOT NULL,
  PRIMARY KEY (`codAnuncio`,`codModelo`),
  KEY `fk_TbAnuncio_has_TbModelo_TbModelo1_idx` (`codModelo`),
  KEY `fk_TbAnuncio_has_TbModelo_TbAnuncio1_idx` (`codAnuncio`),
  CONSTRAINT `fk_TbAnuncio_has_TbModelo_TbAnuncio1` FOREIGN KEY (`codAnuncio`) REFERENCES `tbanuncio` (`codAnuncio`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TbAnuncio_has_TbModelo_TbModelo1` FOREIGN KEY (`codModelo`) REFERENCES `tbmodelo` (`codModelo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `anunciomodelo`
--

LOCK TABLES `anunciomodelo` WRITE;
/*!40000 ALTER TABLE `anunciomodelo` DISABLE KEYS */;
/*!40000 ALTER TABLE `anunciomodelo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetroleclaims`
--

DROP TABLE IF EXISTS `aspnetroleclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(767) NOT NULL,
  `ClaimType` text,
  `ClaimValue` text,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroleclaims`
--

LOCK TABLES `aspnetroleclaims` WRITE;
/*!40000 ALTER TABLE `aspnetroleclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetroleclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetroles`
--

DROP TABLE IF EXISTS `aspnetroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `aspnetroles` (
  `Id` varchar(767) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` text,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`NormalizedName`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroles`
--

LOCK TABLES `aspnetroles` WRITE;
/*!40000 ALTER TABLE `aspnetroles` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserclaims`
--

DROP TABLE IF EXISTS `aspnetuserclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(767) NOT NULL,
  `ClaimType` text,
  `ClaimValue` text,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetUserClaims_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserclaims`
--

LOCK TABLES `aspnetuserclaims` WRITE;
/*!40000 ALTER TABLE `aspnetuserclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserlogins`
--

DROP TABLE IF EXISTS `aspnetuserlogins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(128) NOT NULL,
  `ProviderKey` varchar(128) NOT NULL,
  `ProviderDisplayName` text,
  `UserId` varchar(767) NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  KEY `IX_AspNetUserLogins_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserlogins`
--

LOCK TABLES `aspnetuserlogins` WRITE;
/*!40000 ALTER TABLE `aspnetuserlogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserlogins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserroles`
--

DROP TABLE IF EXISTS `aspnetuserroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(767) NOT NULL,
  `RoleId` varchar(767) NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_AspNetUserRoles_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserroles`
--

LOCK TABLES `aspnetuserroles` WRITE;
/*!40000 ALTER TABLE `aspnetuserroles` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusers`
--

DROP TABLE IF EXISTS `aspnetusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `aspnetusers` (
  `Id` varchar(767) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` bit(1) NOT NULL,
  `PasswordHash` text,
  `SecurityStamp` text,
  `ConcurrencyStamp` text,
  `PhoneNumber` text,
  `PhoneNumberConfirmed` bit(1) NOT NULL,
  `TwoFactorEnabled` bit(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` bit(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  KEY `EmailIndex` (`NormalizedEmail`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusers`
--

LOCK TABLES `aspnetusers` WRITE;
/*!40000 ALTER TABLE `aspnetusers` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusertokens`
--

DROP TABLE IF EXISTS `aspnetusertokens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(767) NOT NULL,
  `LoginProvider` varchar(128) NOT NULL,
  `Name` varchar(128) NOT NULL,
  `Value` text,
  PRIMARY KEY (`UserId`,`LoginProvider`,`Name`),
  CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusertokens`
--

LOCK TABLES `aspnetusertokens` WRITE;
/*!40000 ALTER TABLE `aspnetusertokens` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetusertokens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `negociacaoanuncio`
--

DROP TABLE IF EXISTS `negociacaoanuncio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
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

--
-- Table structure for table `negociacaomodelo`
--

DROP TABLE IF EXISTS `negociacaomodelo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `negociacaomodelo` (
  `codNegociacao` int(11) NOT NULL,
  `codModelo` int(11) NOT NULL,
  PRIMARY KEY (`codNegociacao`,`codModelo`),
  KEY `fk_TbNegociacao_has_TbModelo_TbModelo1_idx` (`codModelo`),
  KEY `fk_TbNegociacao_has_TbModelo_TbNegociacao1_idx` (`codNegociacao`),
  CONSTRAINT `fk_TbNegociacao_has_TbModelo_TbModelo1` FOREIGN KEY (`codModelo`) REFERENCES `tbmodelo` (`codModelo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TbNegociacao_has_TbModelo_TbNegociacao1` FOREIGN KEY (`codNegociacao`) REFERENCES `tbnegociacao` (`codNegociacao`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `negociacaomodelo`
--

LOCK TABLES `negociacaomodelo` WRITE;
/*!40000 ALTER TABLE `negociacaomodelo` DISABLE KEYS */;
/*!40000 ALTER TABLE `negociacaomodelo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `negociacaopagamento`
--

DROP TABLE IF EXISTS `negociacaopagamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `negociacaopagamento` (
  `codNegociacao` int(11) NOT NULL,
  `codPagamento` int(11) NOT NULL,
  PRIMARY KEY (`codNegociacao`,`codPagamento`),
  KEY `fk_TbNegociacao_has_TbPagamento_TbPagamento1_idx` (`codPagamento`),
  KEY `fk_TbNegociacao_has_TbPagamento_TbNegociacao1_idx` (`codNegociacao`),
  CONSTRAINT `fk_TbNegociacao_has_TbPagamento_TbNegociacao1` FOREIGN KEY (`codNegociacao`) REFERENCES `tbnegociacao` (`codNegociacao`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TbNegociacao_has_TbPagamento_TbPagamento1` FOREIGN KEY (`codPagamento`) REFERENCES `tbpagamento` (`codPagamento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `negociacaopagamento`
--

LOCK TABLES `negociacaopagamento` WRITE;
/*!40000 ALTER TABLE `negociacaopagamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `negociacaopagamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbanuncio`
--

DROP TABLE IF EXISTS `tbanuncio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbanuncio` (
  `codAnuncio` int(11) NOT NULL AUTO_INCREMENT,
  `status` enum('Ativo','Inativo') NOT NULL,
  `quantAnunciada` int(11) NOT NULL,
  `quantDisponivel` int(11) NOT NULL,
  `titulo` varchar(45) NOT NULL,
  `descricao` varchar(100) NOT NULL,
  `valor` float NOT NULL,
  `codUsuario` int(11) NOT NULL,
  PRIMARY KEY (`codAnuncio`),
  KEY `fk_TbAnuncio_TbUsuario1_idx` (`codUsuario`),
  CONSTRAINT `fk_TbAnuncio_TbUsuario1` FOREIGN KEY (`codUsuario`) REFERENCES `tbusuario` (`codUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbanuncio`
--

LOCK TABLES `tbanuncio` WRITE;
/*!40000 ALTER TABLE `tbanuncio` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbanuncio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbcategoria`
--

DROP TABLE IF EXISTS `tbcategoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbcategoria` (
  `codCategoria` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  PRIMARY KEY (`codCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbcategoria`
--

LOCK TABLES `tbcategoria` WRITE;
/*!40000 ALTER TABLE `tbcategoria` DISABLE KEYS */;
INSERT INTO `tbcategoria` VALUES (3,'Barquinhos');
/*!40000 ALTER TABLE `tbcategoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbenvio`
--

DROP TABLE IF EXISTS `tbenvio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbenvio` (
  `codEnvio` int(11) NOT NULL AUTO_INCREMENT,
  `valor` float NOT NULL,
  `tipo` enum('PAC','SEDEX','PESSOALMENTE') NOT NULL,
  `endereco` varchar(45) NOT NULL,
  `bairro` varchar(45) NOT NULL,
  `remetente` varchar(45) NOT NULL,
  `destinatario` varchar(45) NOT NULL,
  `complemento` varchar(45) DEFAULT NULL,
  `codNegociacao` int(11) NOT NULL,
  PRIMARY KEY (`codEnvio`),
  KEY `fk_TbEnvio_TbNegociacao_idx` (`codNegociacao`),
  CONSTRAINT `fk_TbEnvio_TbNegociacao` FOREIGN KEY (`codNegociacao`) REFERENCES `tbnegociacao` (`codNegociacao`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbenvio`
--

LOCK TABLES `tbenvio` WRITE;
/*!40000 ALTER TABLE `tbenvio` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbenvio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbmodelo`
--

DROP TABLE IF EXISTS `tbmodelo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
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

--
-- Table structure for table `tbnegociacao`
--

DROP TABLE IF EXISTS `tbnegociacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbnegociacao` (
  `codNegociacao` int(11) NOT NULL AUTO_INCREMENT,
  `data` date NOT NULL,
  `valorProposto` float NOT NULL,
  `status` enum('Aberto','Aguardando contraproposta','Fechado') NOT NULL,
  `tipo` enum('venda','troca','vendaTroca') NOT NULL,
  `codUsuario` int(11) NOT NULL,
  PRIMARY KEY (`codNegociacao`),
  KEY `fk_TbNegociacao_TbUsuario1_idx` (`codUsuario`),
  CONSTRAINT `fk_TbNegociacao_TbUsuario1` FOREIGN KEY (`codUsuario`) REFERENCES `tbusuario` (`codUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbnegociacao`
--

LOCK TABLES `tbnegociacao` WRITE;
/*!40000 ALTER TABLE `tbnegociacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbnegociacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbpagamento`
--

DROP TABLE IF EXISTS `tbpagamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbpagamento` (
  `codPagamento` int(11) NOT NULL AUTO_INCREMENT,
  `valor` float NOT NULL,
  `opcao` enum('Boleto','Cartao') NOT NULL,
  PRIMARY KEY (`codPagamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbpagamento`
--

LOCK TABLES `tbpagamento` WRITE;
/*!40000 ALTER TABLE `tbpagamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbpagamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbsubcategoria`
--

DROP TABLE IF EXISTS `tbsubcategoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbsubcategoria` (
  `codSubcategoria` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `codCategoria` int(11) NOT NULL,
  PRIMARY KEY (`codSubcategoria`),
  KEY `fk_TbSubcategoria_TbCategoria1_idx` (`codCategoria`),
  CONSTRAINT `fk_TbSubcategoria_TbCategoria1` FOREIGN KEY (`codCategoria`) REFERENCES `tbcategoria` (`codCategoria`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbsubcategoria`
--

LOCK TABLES `tbsubcategoria` WRITE;
/*!40000 ALTER TABLE `tbsubcategoria` DISABLE KEYS */;
INSERT INTO `tbsubcategoria` VALUES (1,'Barco',3);
/*!40000 ALTER TABLE `tbsubcategoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbusuario`
--

DROP TABLE IF EXISTS `tbusuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbusuario` (
  `codUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `cpf` varchar(13) NOT NULL,
  `senha` varchar(32) NOT NULL,
  `cidade` varchar(20) NOT NULL,
  `estado` varchar(19) NOT NULL,
  `email` varchar(45) NOT NULL,
  `nome` varchar(45) NOT NULL,
  `cep` varchar(10) NOT NULL,
  `administrador` enum('SIM','NAO') NOT NULL,
  PRIMARY KEY (`codUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbusuario`
--

LOCK TABLES `tbusuario` WRITE;
/*!40000 ALTER TABLE `tbusuario` DISABLE KEYS */;
INSERT INTO `tbusuario` VALUES (1,'4524154','fsdfsdfsd','Itabaiana','Sergipe','igsantos1996@gmail.com','Igor Terriaga Santos','49500787','NAO');
/*!40000 ALTER TABLE `tbusuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-08-27 10:03:28
