-- MySQL Script generated by MySQL Workbench
-- Fri Mar 25 19:10:48 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Examen2
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Examen2
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Examen2` DEFAULT CHARACTER SET utf8 ;
USE `Examen2` ;

-- -----------------------------------------------------
-- Table `Examen2`.`Usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Examen2`.`Usuarios` (
  `Codigo` VARCHAR(15) NOT NULL,
  `Nombre` VARCHAR(45) NULL,
  `Rol` VARCHAR(45) NULL,
  `Clave` VARCHAR(45) NULL,
  `EstaActivo` TINYINT NULL,
  PRIMARY KEY (`Codigo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Examen2`.`Productos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Examen2`.`Productos` (
  `Codigo` VARCHAR(15) NOT NULL,
  `Descripcion` VARCHAR(45) NULL,
  `Precio` DECIMAL(18,2) NULL,
  `Existencia` INT NULL,
  PRIMARY KEY (`Codigo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Examen2`.`Pedidos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Examen2`.`Pedidos` (
  `idPedidos` INT NOT NULL,
  `IdCliente` VARCHAR(45) NULL,
  `Cliente` VARCHAR(45) NULL,
  `Fecha` TIMESTAMP NULL,
  PRIMARY KEY (`idPedidos`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Examen2`.`DetallePedidos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Examen2`.`DetallePedidos` (
  `idDetallePedidos` INT NOT NULL,
  `idPedidos` INT NOT NULL,
  `CodigoProducto` VARCHAR(15) NOT NULL,
  `Descripcion` VARCHAR(45) NULL,
  `Cantidad` INT NULL,
  `Precio` DECIMAL NULL,
  `Total` DECIMAL NULL,
  PRIMARY KEY (`idDetallePedidos`),
  INDEX `Fk_detallePedidos_pedidos_idx` (`idPedidos` ASC) VISIBLE,
  INDEX `Fk_detallePedidos_productos_idx` (`CodigoProducto` ASC) VISIBLE,
  CONSTRAINT `Fk_detallePedidos_pedidos`
    FOREIGN KEY (`idPedidos`)
    REFERENCES `Examen2`.`Pedidos` (`idPedidos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Fk_detallePedidos_productos`
    FOREIGN KEY (`CodigoProducto`)
    REFERENCES `Examen2`.`Productos` (`Codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;