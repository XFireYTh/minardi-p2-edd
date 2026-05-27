
# ✈️ ViajaMais API

> **Sistema de Gerenciamento de Pacotes, Clientes e Reservas de Viagens.**
> Uma solução robusta desenvolvida para otimizar, automatizar e centralizar as operações de uma agência de turismo moderna.

---

## 👥 Participantes
Conheça os desenvolvedores responsáveis por este projeto:
* **Gabriel Philippe Souza da Silva**
* **Raphael Pereira Guizardi da Silva**
* **Thomas Jefferson Silva Zompero De Morais**
* **Yago Goncalves Ronconi**

---

## 💡 Justificativa do Projeto
O mercado de turismo exige dinamismo na oferta de pacotes, controle rigoroso de vagas e histórico detalhado de escolhas dos clientes. A **ViajaMais API** resolve esse problema centralizando o cadastro de clientes, destinos e hotéis, além de gerenciar de forma automatizada as reservas. 

A escolha deste domínio se justifica pela necessidade inerente de relacionamentos complexos no ecossistema de banco de dados: um hotel pertence a um destino específico (1:N), e um cliente pode contratar vários pacotes de viagem, assim como um pacote pode ser contratado por vários clientes através de reservas, gerando a relação de muitos para muitos (N:M) ideal para a maturidade do escopo acadêmico.

---

## 🗺️ Modelagem de Dados (Arquitetura)

O sistema foi modelado para garantir integridade referencial e consistência dos dados. Abaixo estão as entidades e o diagrama visual que compõem o núcleo do sistema:

### 📦 Entidades

* **Cliente:** Dados cadastrais e de contato do viajante.
* **Destino:** Cidades ou locais turísticos operados pela agência.
* **Hotel:** Estabelecimentos de hospedagem vinculados obrigatoriamente a um destino.
* **PacoteViagem:** O produto turístico comercializado (combina um destino, preço, vagas, data de saída e retorno).
* **Reserva:** Entidade associativa que conecta *Cliente* e *PacoteViagem*, contendo o status do pagamento, quantidade de passageiros e data da compra.

### 🖼️ Diagrama Entidade-Relacionamento (ER)

Abaixo, a representação visual da estrutura do banco de dados:

<p align="center">
  <img src="https://ibb.co/HDftc3xX" width="80%">
</p>

### 📊 Matriz de Relacionamentos e Cardinalidade

| Entidade Origem | Cardinalidade | Entidade Destino | Descrição |
| :--- | :---: | :--- | :--- |
| **Destino** | **1 : N** | **Hotel** | Um destino pode ter vários hotéis parceiros cadastrados. |
| **Destino** | **1 : N** | **PacoteViagem** | Um destino pode ser a base de múltiplos pacotes turísticos. |
| **Cliente** | **1 : N** | **Reserva** | Um cliente pode realizar várias reservas ao longo do tempo. |
| **PacoteViagem** | **1 : N** | **Reserva** | Um pacote de viagem pode receber reservas de diversos clientes. |
| **Cliente** | **N : M** | **PacoteViagem** | Relacionamento gerenciado através da tabela associativa **Reserva**. |
