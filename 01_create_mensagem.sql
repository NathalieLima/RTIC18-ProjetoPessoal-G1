CREATE TABLE IF NOT EXISTS `mydb`.`mensagem` (
  `idmensagem` INT NOT NULL,
  `id_remetente` VARCHAR(45) NULL,
  `id_destinatario` VARCHAR(45) NULL,
  `data_hota` VARCHAR(45) NULL,
  `mensagem` VARCHAR(45) NULL,
  `conversa_idmensagem` INT NOT NULL,
  PRIMARY KEY (`idmensagem`))
ENGINE = InnoDB;
