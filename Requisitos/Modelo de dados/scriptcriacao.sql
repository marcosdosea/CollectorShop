-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`usuario` (
  `codUsuario` INT NOT NULL,
  `cpf` VARCHAR(11) NOT NULL,
  `senha` VARCHAR(32) NOT NULL,
  `cidade` VARCHAR(20) NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `estado` VARCHAR(19) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `nome` VARCHAR(45) NOT NULL,
  `cep` VARCHAR(10) NOT NULL,
  `administrador` TINYINT NOT NULL,
  PRIMARY KEY (`codUsuario`));


-- -----------------------------------------------------
-- Table `mydb`.`anuncio`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`anuncio` (
  `codAnuncio` INT NOT NULL,
  `status` SET('ATIVO', 'INATIVO') NOT NULL,
  `quantAnunciada` INT NOT NULL,
  `quantDisponivel` INT NULL,
  `titulo` VARCHAR(45) NULL,
  `descricao` VARCHAR(100) NULL,
  `valor` FLOAT NULL,
  `codUsuario` INT NOT NULL,
  `msg` VARCHAR(250) NULL,
  PRIMARY KEY (`codAnuncio`),
  INDEX `fk_Anuncio_Usuario1_idx` (`codUsuario` ASC),
  CONSTRAINT `fk_Anuncio_Usuario1`
    FOREIGN KEY (`codUsuario`)
    REFERENCES `mydb`.`usuario` (`codUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `mydb`.`categoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`categoria` (
  `codCategoria` INT NOT NULL,
  `nome` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`codCategoria`));


-- -----------------------------------------------------
-- Table `mydb`.`subCategoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`subCategoria` (
  `codSubcategoria` INT NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `nome` VARCHAR(20) NOT NULL,
  `codCategoria` INT NOT NULL,
  PRIMARY KEY (`codSubcategoria`),
  INDEX `fk_SubCategoria_Categoria1_idx` (`codCategoria` ASC),
  CONSTRAINT `fk_SubCategoria_Categoria1`
    FOREIGN KEY (`codCategoria`)
    REFERENCES `mydb`.`categoria` (`codCategoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `mydb`.`modelo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`modelo` (
  `codModelo` INT NOT NULL,
  `nome` VARCHAR(32) NOT NULL,
  `quantTiragem` VARCHAR(20) NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `colecao` VARCHAR(45) NOT NULL,
  `label` VARCHAR(45) NOT NULL,
  `marca` VARCHAR(45) NOT NULL,
  `ano` VARCHAR(4) NOT NULL,
  `codSubcategoria` INT NOT NULL,
  `codUsuario` INT NOT NULL,
  PRIMARY KEY (`codModelo`),
  INDEX `fk_Modelo_SubCategoria1_idx` (`codSubcategoria` ASC),
  INDEX `fk_Modelo_Usuario1_idx` (`codUsuario` ASC),
  CONSTRAINT `fk_Modelo_SubCategoria1`
    FOREIGN KEY (`codSubcategoria`)
    REFERENCES `mydb`.`subCategoria` (`codSubcategoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Modelo_Usuario1`
    FOREIGN KEY (`codUsuario`)
    REFERENCES `mydb`.`usuario` (`codUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `mydb`.`anuncioModelo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`anuncioModelo` (
  `codAnuncio` VARCHAR(16) NOT NULL,
  `codModelo` VARCHAR(16) NOT NULL,
  PRIMARY KEY (`codAnuncio`, `codModelo`),
  INDEX `fk_Anuncio_has_modelo_modelo1_idx` (`codModelo` ASC),
  INDEX `fk_Anuncio_has_modelo_Anuncio1_idx` (`codAnuncio` ASC),
  CONSTRAINT `fk_Anuncio_has_modelo_Anuncio1`
    FOREIGN KEY (`codAnuncio`)
    REFERENCES `mydb`.`anuncio` (`codAnuncio`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Anuncio_has_modelo_modelo1`
    FOREIGN KEY (`codModelo`)
    REFERENCES `mydb`.`modelo` (`codModelo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `mydb`.`pagamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`pagamento` (
  `codPagamento` INT NOT NULL,
  `opcao` VARCHAR(10) NOT NULL,
  `valor` FLOAT NOT NULL,
  PRIMARY KEY (`codPagamento`));


-- -----------------------------------------------------
-- Table `mydb`.`envio`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`envio` (
  `codEnvio` INT NOT NULL,
  `preco` FLOAT NOT NULL,
  `tipo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`codEnvio`));


-- -----------------------------------------------------
-- Table `mydb`.`compra`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`compra` (
  `codCompra` INT NOT NULL,
  `data` DATE NOT NULL,
  `valorTotal` FLOAT NOT NULL,
  `codEnvio` INT NOT NULL,
  `codPagamento` INT NOT NULL,
  `codUsuario` INT NULL,
  `valorUnitario` FLOAT NULL,
  `codModelo` INT NOT NULL,
  PRIMARY KEY (`codCompra`),
  INDEX `fk_Compra_Envio1_idx` (`codEnvio` ASC),
  INDEX `fk_Compra_Pagamento1_idx` (`codPagamento` ASC),
  UNIQUE INDEX `Pagamento_codPagamento_UNIQUE` (`codPagamento` ASC),
  UNIQUE INDEX `Envio_codEnvio_UNIQUE` (`codEnvio` ASC),
  INDEX `fk_Compra_Usuario1_idx` (`codUsuario` ASC),
  INDEX `fk_Compra_Modelo1_idx` (`codModelo` ASC),
  CONSTRAINT `fk_Compra_Envio1`
    FOREIGN KEY (`codEnvio`)
    REFERENCES `mydb`.`envio` (`codEnvio`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Compra_Pagamento1`
    FOREIGN KEY (`codPagamento`)
    REFERENCES `mydb`.`pagamento` (`codPagamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Compra_Usuario1`
    FOREIGN KEY (`codUsuario`)
    REFERENCES `mydb`.`usuario` (`codUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Compra_Modelo1`
    FOREIGN KEY (`codModelo`)
    REFERENCES `mydb`.`modelo` (`codModelo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `mydb`.`usuarioSubCategoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`usuarioSubCategoria` (
  `codUsuario` INT NOT NULL,
  `codSubcategoria` INT NOT NULL,
  PRIMARY KEY (`codUsuario`, `codSubcategoria`),
  INDEX `fk_Usuario_has_SubCategoria_SubCategoria1_idx` (`codSubcategoria` ASC),
  INDEX `fk_Usuario_has_SubCategoria_Usuario1_idx` (`codUsuario` ASC),
  CONSTRAINT `fk_Usuario_has_SubCategoria_Usuario1`
    FOREIGN KEY (`codUsuario`)
    REFERENCES `mydb`.`usuario` (`codUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Usuario_has_SubCategoria_SubCategoria1`
    FOREIGN KEY (`codSubcategoria`)
    REFERENCES `mydb`.`subCategoria` (`codSubcategoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `mydb`.`usuarioCategoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`usuarioCategoria` (
  `codUsuario` INT NOT NULL,
  `codCategoria` INT NOT NULL,
  PRIMARY KEY (`codUsuario`, `codCategoria`),
  INDEX `fk_Usuario_has_Categoria_Categoria1_idx` (`codCategoria` ASC),
  INDEX `fk_Usuario_has_Categoria_Usuario1_idx` (`codUsuario` ASC),
  CONSTRAINT `fk_Usuario_has_Categoria_Usuario1`
    FOREIGN KEY (`codUsuario`)
    REFERENCES `mydb`.`usuario` (`codUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Usuario_has_Categoria_Categoria1`
    FOREIGN KEY (`codCategoria`)
    REFERENCES `mydb`.`categoria` (`codCategoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `mydb`.`troca`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`troca` (
  `codTroca` INT NOT NULL,
  `quantidade` INT NOT NULL,
  `data` DATE NOT NULL,
  `codEnvio` INT NOT NULL,
  `codPagamento` INT NOT NULL,
  `codUsuario` INT NOT NULL,
  PRIMARY KEY (`codTroca`, `codUsuario`),
  INDEX `fk_Troca_Envio1_idx` (`codEnvio` ASC),
  INDEX `fk_Troca_Pagamento1_idx` (`codPagamento` ASC),
  INDEX `fk_Troca_Usuario1_idx` (`codUsuario` ASC),
  CONSTRAINT `fk_Troca_Envio1`
    FOREIGN KEY (`codEnvio`)
    REFERENCES `mydb`.`envio` (`codEnvio`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Troca_Pagamento1`
    FOREIGN KEY (`codPagamento`)
    REFERENCES `mydb`.`pagamento` (`codPagamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Troca_Usuario1`
    FOREIGN KEY (`codUsuario`)
    REFERENCES `mydb`.`usuario` (`codUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`trocaModelo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`trocaModelo` (
  `trocaCodTroca` INT NOT NULL,
  `modeloCodModelo` INT NOT NULL,
  PRIMARY KEY (`trocaCodTroca`, `modeloCodModelo`),
  INDEX `fk_Troca_has_Modelo_Modelo1_idx` (`modeloCodModelo` ASC),
  INDEX `fk_Troca_has_Modelo_Troca1_idx` (`trocaCodTroca` ASC),
  CONSTRAINT `fk_Troca_has_Modelo_Troca1`
    FOREIGN KEY (`trocaCodTroca`)
    REFERENCES `mydb`.`troca` (`codTroca`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Troca_has_Modelo_Modelo1`
    FOREIGN KEY (`modeloCodModelo`)
    REFERENCES `mydb`.`modelo` (`codModelo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`trocaAnuncio`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`trocaAnuncio` (
  `codTroca` INT NOT NULL,
  `codAnuncio` INT NOT NULL,
  PRIMARY KEY (`codTroca`, `codAnuncio`),
  INDEX `fk_Troca_has_Anuncio_Anuncio1_idx` (`codAnuncio` ASC),
  INDEX `fk_Troca_has_Anuncio_Troca1_idx` (`codTroca` ASC),
  CONSTRAINT `fk_Troca_has_Anuncio_Troca1`
    FOREIGN KEY (`codTroca`)
    REFERENCES `mydb`.`troca` (`codTroca`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Troca_has_Anuncio_Anuncio1`
    FOREIGN KEY (`codAnuncio`)
    REFERENCES `mydb`.`anuncio` (`codAnuncio`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
