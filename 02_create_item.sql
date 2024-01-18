CREATE TABLE IF NOT EXISTS `mydb`.`usuario` (
  `id_usuario` INT NOT NULL,
  `nome` VARCHAR(45) NULL,
  `login` VARCHAR(45) NULL,
  `senha` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  `cpf` VARCHAR(45) NULL,
  `status` TINYINT NULL,
  `rg` VARCHAR(45) NULL,
  `endereco` VARCHAR(45) NULL,
  `data_nascimento` VARCHAR(45) NULL,
  `credito` DECIMAL NULL,
  `link_linkedln` VARCHAR(45) NULL,
  `sobre` LONGTEXT NULL,
  `usuariocol` VARCHAR(45) NULL,
  PRIMARY KEY (`id_usuario`))
ENGINE = InnoDB;