# RTIC18-ProjetoPessoal-G1

# Descrição do Projeto "Escambo":

Escambo será uma plataforma online que facilita a troca de serviços entre usuários. 
No Escambo, os usuários podem atuar como prestadores de serviços, anunciando os serviços que oferecem, e como contratantes, contratando serviços de outros usuários. 
Todos os serviços são essencialmente gratuitos.

Os usuários, como contratantes, podem navegar pelos anúncios e contratar serviços. 
Cada prestação de servico está associada a um único anúncio de serviço.

O projeto tem como intenção dar oportunidade à pessoas de adquirir experiência
com trabalhos de sua área que ela se candidatar, enquanto fornece soluções gratuitas
a problemas e demandas simples. Além disso, os trabalhos feitos poderão ser exibidos
no linkedin do usuário.

O Contratante (usuário que faz uma requisição de serviço) poderá entrar em contato
com o Prestador (usuário que presta o serviço) e vice-versa, para discutir detalhes
do serviço. Portanto, um chat será necessário.

## Entidades:

### Usuario
Além das variáveis padrão de um usuário (nome, email, cpf, entre outros), ele também possui:
- "credito", que é uma moeda referente ao tempo e à complexidade dos trabalhos feitos
- "link_linkedIn" do usuário (não obrigatório);
- "sobre", que é uma descrição do usuário (não obrigatório)

ele tem uma relação de 0-n com "conversa" e 0-n com "prestacao_servico"

### Conversa
Guarda o id tanto do remetente quanto do destinatário e possui uma relação 0-n com "mensagem"

### Mensagem
Guarda o id do remetente e do destinatário, a Data-hora e o conteúdo da mensagem

### Prestacao_servico
Guarda o id do Contratante e do Prestador, além da Data-hora de inicio e de conclusão.
Cada prestação possui 0-1 item

### Anuncio
O usuário anuncia os serviços que oferece. 
Cada anúncio inclui detalhes sobre o serviço, bem como a quantidade de créditos que o usuário considera adequada para a prestação do serviço.

### Avaliacao 
Após a conclusão de uma contratação, tanto o prestador quanto o contratante têm a oportunidade de avaliar um ao outro. 
Essas avaliações ajudam a construir a reputação dos usuários na plataforma e a garantir a qualidade dos serviços oferecidos.
