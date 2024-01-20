
CREATE SCHEMA IF NOT EXISTS `escambo`;
USE `escambo`;

CREATE TABLE IF NOT EXISTS `escambo`.`item` (
  `id_servico` INT NOT NULL,
  `descricao` LONGTEXT NULL,
  `credito` DECIMAL NOT NULL,
  `categoria` VARCHAR(45) NULL,
  `tipo` VARCHAR(45) NULL,
  PRIMARY KEY (`id_servico`)
);

CREATE TABLE IF NOT EXISTS `escambo`.`usuario` (
  `id_usuario` INT NOT NULL,
  `email` VARCHAR(45) NULL,
  `senha` VARCHAR(45) NOT NULL,
  `cpf` VARCHAR(45) NOT NULL,
  `nome` VARCHAR(45) NULL,
  `status` TINYINT NULL,
  `rg` VARCHAR(45) NULL,
  `endereco` VARCHAR(45) NULL,
  `data_nascimento` VARCHAR(10) NOT NULL,
  `credito` DECIMAL NOT NULL,
  `link_linkedln` VARCHAR(250) NULL,
  `sobre` LONGTEXT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `escambo`.`prestacao_servico` (
  `idprestacao_servico` INT NOT NULL,
  `data_hora_inicio` DATE NOT NULL,
  `data_hora_conclusao` DATE NULL,
  `status` VARCHAR(45) NOT NULL,
  `credito` DECIMAL NOT NULL,
  `contratante_id_usuario` INT NOT NULL,
  `prestador_id_usuario` INT NOT NULL,
  `item_id_servico` INT NOT NULL,
  PRIMARY KEY (`idprestacao_servico`),
  INDEX `fk_prestacao_servico_usuario1_idx` (`contratante_id_usuario` ASC) VISIBLE,
  INDEX `fk_prestacao_servico_usuario2_idx` (`prestador_id_usuario` ASC) VISIBLE,
  INDEX `fk_prestacao_servico_item1_idx` (`item_id_servico` ASC) VISIBLE,
  CONSTRAINT `fk_prestacao_servico_usuario1`
    FOREIGN KEY (`contratante_id_usuario`)
    REFERENCES `escambo`.`usuario` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_prestacao_servico_usuario2`
    FOREIGN KEY (`prestador_id_usuario`)
    REFERENCES `escambo`.`usuario` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_prestacao_servico_item1`
    FOREIGN KEY (`item_id_servico`)
    REFERENCES `escambo`.`item` (`id_servico`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `escambo`.`conversa` (
  `idmensagem` INT NOT NULL,
  `data_hora_inicio` VARCHAR(45) NOT NULL,
  `remetente_id_usuario` INT NOT NULL,
  `destinatario_id_usuario1` INT NOT NULL,
  PRIMARY KEY (`idmensagem`),
  INDEX `fk_conversa_usuario1_idx` (`remetente_id_usuario` ASC) VISIBLE,
  INDEX `fk_conversa_usuario2_idx` (`destinatario_id_usuario1` ASC) VISIBLE,
  CONSTRAINT `fk_conversa_usuario1`
    FOREIGN KEY (`remetente_id_usuario`)
    REFERENCES `escambo`.`usuario` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_conversa_usuario2`
    FOREIGN KEY (`destinatario_id_usuario1`)
    REFERENCES `escambo`.`usuario` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `escambo`.`mensagem` (
  `idmensagem` INT NOT NULL,
  `id_remetente` VARCHAR(45) NULL,
  `id_destinatario` VARCHAR(45) NULL,
  `data_hota` VARCHAR(45) NULL,
  `mensagem` VARCHAR(45) NULL,
  `conversa_idmensagem` INT NOT NULL,
  PRIMARY KEY (`idmensagem`),
  INDEX `fk_mensagem_conversa1_idx` (`conversa_idmensagem` ASC) VISIBLE,
  CONSTRAINT `fk_mensagem_conversa1`
    FOREIGN KEY (`conversa_idmensagem`)
    REFERENCES `escambo`.`conversa` (`idmensagem`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB;
