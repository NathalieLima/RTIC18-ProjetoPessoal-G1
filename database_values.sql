INSERT INTO `escambo`.`item` (`id_servico`, `descricao`, `credito`, `categoria`, `tipo`) VALUES
(1, 'Serviço de pintura', 50.00, 'Serviços domésticos', 'Pintura'),
(2, 'Aula de programação', 30.00, 'Educação', 'Programação'),
(3, 'Serviço de jardinagem', 40.00, 'Serviços domésticos', 'Jardinagem'),
(4, 'Design de logotipo', 25.00, 'Design', 'Logotipo'),
(5, 'Assistência técnica', 35.00, 'Tecnologia', 'Assistência Técnica');

INSERT INTO `escambo`.`usuario` (`id_usuario`, `email`, `senha`, `cpf`, `nome`, `status`, `rg`, `endereco`, `data_nascimento`, `credito`, `link_linkedln`, `sobre`) VALUES
(1, 'usuario1@example.com', 'senha123', '123.456.789-01', 'Usuário 1', 1, '1234567', 'Rua A, 123', '1990-05-15', 100.00, 'https://www.linkedin.com/in/usuario1', 'Descrição sobre o usuário 1'),
(2, 'usuario2@example.com', 'senha456', '987.654.321-01', 'Usuário 2', 1, '7654321', 'Rua B, 456', '1985-10-20', 80.00, 'https://www.linkedin.com/in/usuario2', 'Descrição sobre o usuário 2'),
(3, 'usuario3@example.com', 'senha789', '111.222.333-01', 'Usuário 3', 0, '1112223', 'Rua C, 789', '1995-08-02', 120.00, 'https://www.linkedin.com/in/usuario3', 'Descrição sobre o usuário 3'),
(4, 'usuario4@example.com', 'senhaabc', '444.555.666-01', 'Usuário 4', 1, '4445566', 'Rua D, 987', '1982-03-12', 150.00, 'https://www.linkedin.com/in/usuario4', 'Descrição sobre o usuário 4'),
(5, 'usuario5@example.com', 'senhaxyz', '777.888.999-01', 'Usuário 5', 1, '7778899', 'Rua E, 654', '1998-12-05', 90.00, 'https://www.linkedin.com/in/usuario5', 'Descrição sobre o usuário 5');

INSERT INTO `escambo`.`prestacao_servico` (`idprestacao_servico`, `data_hora_inicio`, `data_hora_conclusao`, `status`, `credito`, `contratante_id_usuario`, `prestador_id_usuario`, `item_id_servico`) VALUES
(1, '2024-01-20', NULL, 'Em andamento', 30.00, 1, 2, 1),
(2, '2024-01-21', '2024-01-25', 'Concluído', 40.00, 3, 4, 3),
(3, '2024-01-22', NULL, 'Em andamento', 25.00, 2, 5, 2),
(4, '2024-01-23', NULL, 'Em andamento', 35.00, 4, 1, 4),
(5, '2024-01-24', '2024-01-26', 'Concluído', 50.00, 5, 3, 5);

INSERT INTO `escambo`.`conversa` (`idmensagem`, `data_hora_inicio`, `remetente_id_usuario`, `destinatario_id_usuario1`) VALUES
(1, '2024-01-20 09:00:00', 1, 2),
(2, '2024-01-21 10:30:00', 3, 4),
(3, '2024-01-22 12:45:00', 2, 5),
(4, '2024-01-23 15:20:00', 4, 1),
(5, '2024-01-24 18:10:00', 5, 3);

INSERT INTO `escambo`.`mensagem` (`idmensagem`, `id_remetente`, `id_destinatario`, `data_hota`, `mensagem`, `conversa_idmensagem`) VALUES
(1, 'remetente1', 'destinatario1', '2024-01-20 09:05:00', 'Olá, podemos discutir detalhes?', 1),
(2, 'remetente3', 'destinatario4', '2024-01-21 11:00:00', 'Disponível próxima semana.', 2),
(3, 'remetente2', 'destinatario5', '2024-01-22 13:00:00', 'Gostaria de saber mais.', 3),
(4, 'remetente4', 'destinatario1', '2024-01-23 15:30:00', 'Vamos marcar um horário?', 4),
(5, 'remetente5', 'destinatario3', '2024-01-24 18:30:00', 'Ansioso para trabalhar.', 5);
