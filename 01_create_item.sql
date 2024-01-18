CREATE TABLE IF NOT EXISTS `escambo`.`item` (
  `id_servico` INT NOT NULL,
  `descricao` LONGTEXT NULL,
  `credito` DECIMAL NOT NULL,
  `categoria` VARCHAR(45) NULL,
  `tipo` VARCHAR(45) NULL,
  PRIMARY KEY (`id_servico`))
ENGINE = InnoDB;
