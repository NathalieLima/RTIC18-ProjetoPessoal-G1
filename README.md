# RTIC18-ProjetoPessoal-G1

# Descrição dos endpoints iniciais do projeto:

Antes de discutir os endpoints, vamos listar todas as entidades presentes 
no nosso projeto, sendo elas:

- usuarios
- prestacao_servico
- anuncios
- prestacao_servico_has_avaliacoes
- avaliacoes
- conversas
- mensagem

A principio, todas as entidades do projeto terão os dois seguintes tipos de endpoints:
- GetByID
- GetAll
- Post
- Delete

Apenas Usuarios, Prestacoes, Anuncios, Avaliacoes e Mensagens terão endpoints do tipo "PUT"

Entidades como "usuarios" que possuem uma lista de instancia de outras entidades
poderão buscar todas as instancias daquela entidade que estão relacionadas a ela,
sendo elas:

- usuario/{id}/conversas (buscará todas as conversas ligadas a um usuário)
- usuario/{id}/anuncios (todos os anuncios ligados a ele)
- usuario/{id}/prestacao_servicos

- anuncio/{id}/prestacao_servicos

- conversa/{id}/mensagem

- prestacao_servicos/{id}/avaliacoes

