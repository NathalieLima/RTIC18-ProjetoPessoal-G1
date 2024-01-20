CREATE TABLE IF NOT EXISTS `mydb`.`prestacao_servico` (
`idprestacao_servico` INT NOT NULL,
`data_hora_inicio` DATE NULL,
`data_hora_conclusao` DATE NULL,
`status` VARCHAR(45) NULL,
`credito` DECIMAL NULL,
`contratante_id_usuario` INT NOT NULL,
`prestador_id_usuario` INT NOT NULL,
`item_id_servico` INT NOT NULL,
PRIMARY KEY (`idprestacao_servico`))
ENGINE = InnoDB;