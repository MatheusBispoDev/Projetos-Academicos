-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11-Dez-2019 às 03:20
-- Versão do servidor: 10.4.8-MariaDB
-- versão do PHP: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bd_condominio`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_condominio`
--

CREATE TABLE `tb_condominio` (
  `codigo` int(11) NOT NULL,
  `empresa` int(11) DEFAULT NULL,
  `andar` char(2) DEFAULT NULL,
  `salas` int(11) DEFAULT NULL,
  `vagas_estacionamento` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_condominio`
--

INSERT INTO `tb_condominio` (`codigo`, `empresa`, `andar`, `salas`, `vagas_estacionamento`) VALUES
(1, 1, '1°', 5, 20),
(2, 2, '3°', 4, 30),
(3, 3, '2°', 2, 5);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_contas_condominio`
--

CREATE TABLE `tb_contas_condominio` (
  `codigo` int(11) NOT NULL,
  `condominio` int(11) DEFAULT NULL,
  `consumo_agua` double DEFAULT NULL,
  `consumo_energia` double DEFAULT NULL,
  `taxa_manutencao` double DEFAULT NULL,
  `valor_condominio` double DEFAULT NULL,
  `data_contas` varchar(8) DEFAULT NULL,
  `total` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_contas_condominio`
--

INSERT INTO `tb_contas_condominio` (`codigo`, `condominio`, `consumo_agua`, `consumo_energia`, `taxa_manutencao`, `valor_condominio`, `data_contas`, `total`) VALUES
(1, 1, 200, 300, 120, 2000, '10/12/19', 2620),
(2, 2, 50, 140, 20, 3000, '10/12/19', 3210);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_dedetizacao`
--

CREATE TABLE `tb_dedetizacao` (
  `codigo` int(11) NOT NULL,
  `condominio` int(11) DEFAULT NULL,
  `empresa_resp` varchar(50) DEFAULT NULL,
  `data_dede` varchar(8) DEFAULT NULL,
  `descricao` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_dedetizacao`
--

INSERT INTO `tb_dedetizacao` (`codigo`, `condominio`, `empresa_resp`, `data_dede`, `descricao`) VALUES
(1, 1, 'VeniCodi', '09/12/19', 'Dedetização feita em todo o predio'),
(2, 2, 'VeniCodi', '08/12/19', 'Dedetização feita somente no andar 4°'),
(3, 3, 'Capgemi', '10/12/19', 'Dedetização feita no andar 2°');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_empresa`
--

CREATE TABLE `tb_empresa` (
  `codigo` int(11) NOT NULL,
  `locador` varchar(15) DEFAULT NULL,
  `nome_Fantasia` varchar(50) DEFAULT NULL,
  `razao_Social` varchar(50) DEFAULT NULL,
  `cnpj` char(18) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_empresa`
--

INSERT INTO `tb_empresa` (`codigo`, `locador`, `nome_Fantasia`, `razao_Social`, `cnpj`) VALUES
(1, '55.464.050-4', 'VeniCodi', 'Venicodi', '15.151.531/4531-45'),
(2, '41.151.531-5', 'Atos Enterprise', 'Atos ES', '23.102.301/2013-22'),
(3, '41.351.543-1', 'Capgemi', 'CapGemi SA', '23.102.301/2013-22');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_funcionario`
--

CREATE TABLE `tb_funcionario` (
  `rg` varchar(15) NOT NULL,
  `empresa` int(11) DEFAULT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `telefone` varchar(15) DEFAULT NULL,
  `endereco` varchar(50) DEFAULT NULL,
  `num` int(11) DEFAULT NULL,
  `cep` char(15) DEFAULT NULL,
  `foto` varchar(255) DEFAULT NULL,
  `cargo` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_funcionario`
--

INSERT INTO `tb_funcionario` (`rg`, `empresa`, `nome`, `telefone`, `endereco`, `num`, `cep`, `foto`, `cargo`) VALUES
('11.151.515-3', 2, 'Michael Magalhães', '(11)9.8468-4468', 'Rua Santa de Parnaiba', 12, '13515-353', 'C:\\Users\\Familia Coelho\\Documents\\NetBeansProjects\\projetoCondominio\\Imagens\\Michael.jpg', 'Desenvolvedor de Sistemas Senior'),
('31.351.531-5', 2, 'Luiz Cezar', '(11)9.4854-1531', 'Rua Santana de Parnaiba', 26, '15315-315', 'C:\\Users\\Familia Coelho\\Documents\\NetBeansProjects\\projetoCondominio\\Imagens\\Luiz Cezar.jpg', 'Estagiario');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_manutencao_ele`
--

CREATE TABLE `tb_manutencao_ele` (
  `codigo` int(11) NOT NULL,
  `condominio` int(11) DEFAULT NULL,
  `data_manu` varchar(8) DEFAULT NULL,
  `elevador` varchar(15) DEFAULT NULL,
  `empresa_respo` varchar(50) DEFAULT NULL,
  `descr` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_manutencao_ele`
--

INSERT INTO `tb_manutencao_ele` (`codigo`, `condominio`, `data_manu`, `elevador`, `empresa_respo`, `descr`) VALUES
(1, 3, '10/12/19', 'Elevador 2', 'Capgemi', 'Elevador Concertado'),
(2, 2, '09/10/19', 'Elevador 1', 'Capgemi', 'Elevador Concertado');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_materiais`
--

CREATE TABLE `tb_materiais` (
  `codigo` int(11) NOT NULL,
  `nome` varchar(30) DEFAULT NULL,
  `descr` varchar(60) DEFAULT NULL,
  `valor` double DEFAULT NULL,
  `img` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_materiais`
--

INSERT INTO `tb_materiais` (`codigo`, `nome`, `descr`, `valor`, `img`) VALUES
(1, 'Cadeira', 'Cadeira de escritorio', 20.5, 'C:\\Users\\Familia Coelho\\Documents\\NetBeansProjects\\projetoCondominio\\Imagens\\cadeira.jpg'),
(2, 'Lixeira', 'Lixeira de escritorio', 12.6, 'C:\\Users\\Familia Coelho\\Documents\\NetBeansProjects\\projetoCondominio\\Imagens\\lixeira.jpg'),
(3, 'Mesa', 'Mesa de escritorio', 35.9, 'C:\\Users\\Familia Coelho\\Documents\\NetBeansProjects\\projetoCondominio\\Imagens\\mesa escritorio.jpg'),
(4, 'Ar condicionado', 'Ar condicionado de escritorio', 250.8, 'C:\\Users\\Familia Coelho\\Documents\\NetBeansProjects\\projetoCondominio\\Imagens\\ar condicionado.jpg');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_recepcao`
--

CREATE TABLE `tb_recepcao` (
  `codigo` int(11) NOT NULL,
  `dia` char(8) DEFAULT NULL,
  `hora` char(8) DEFAULT NULL,
  `rg` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_recepcao`
--

INSERT INTO `tb_recepcao` (`codigo`, `dia`, `hora`, `rg`) VALUES
(1, '11/12/19', '00:13:37', '43.242.324-3'),
(2, '11/12/19', '00:14:24', '46.485.411-4');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_usuarios`
--

CREATE TABLE `tb_usuarios` (
  `login` varchar(30) NOT NULL,
  `senha` varchar(30) DEFAULT NULL,
  `nivel_acesso` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_usuarios`
--

INSERT INTO `tb_usuarios` (`login`, `senha`, `nivel_acesso`) VALUES
('Luiz', '123', 'Recepção'),
('Matheus', '123', 'ADM'),
('Michael', '123', 'Locatários'),
('Paulo', '123', 'Locadores');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_visitante`
--

CREATE TABLE `tb_visitante` (
  `rg` varchar(15) NOT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `telefone` varchar(15) DEFAULT NULL,
  `endereco` varchar(50) DEFAULT NULL,
  `num` int(11) DEFAULT NULL,
  `cep` char(15) DEFAULT NULL,
  `foto` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_visitante`
--

INSERT INTO `tb_visitante` (`rg`, `nome`, `telefone`, `endereco`, `num`, `cep`, `foto`) VALUES
('43.242.324-3', 'Paulo Henrique', '(11)9.5153-1531', 'Rua Barueri', 153, '51315-315', 'C:\\Users\\Familia Coelho\\Documents\\NetBeansProjects\\projetoCondominio\\Imagens\\Paulo.jpg'),
('46.485.411-4', 'Vitor Susa', '(11)9.5153-1531', 'Rua Carapicuiba', 152, '15315-313', 'C:\\Users\\Familia Coelho\\Documents\\NetBeansProjects\\projetoCondominio\\Imagens\\Vitor susa.jpg');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tb_condominio`
--
ALTER TABLE `tb_condominio`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `empresa` (`empresa`);

--
-- Índices para tabela `tb_contas_condominio`
--
ALTER TABLE `tb_contas_condominio`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `condominio` (`condominio`);

--
-- Índices para tabela `tb_dedetizacao`
--
ALTER TABLE `tb_dedetizacao`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `condominio` (`condominio`);

--
-- Índices para tabela `tb_empresa`
--
ALTER TABLE `tb_empresa`
  ADD PRIMARY KEY (`codigo`);

--
-- Índices para tabela `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  ADD PRIMARY KEY (`rg`),
  ADD KEY `empresa` (`empresa`);

--
-- Índices para tabela `tb_manutencao_ele`
--
ALTER TABLE `tb_manutencao_ele`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `condominio` (`condominio`);

--
-- Índices para tabela `tb_materiais`
--
ALTER TABLE `tb_materiais`
  ADD PRIMARY KEY (`codigo`);

--
-- Índices para tabela `tb_recepcao`
--
ALTER TABLE `tb_recepcao`
  ADD PRIMARY KEY (`codigo`);

--
-- Índices para tabela `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  ADD PRIMARY KEY (`login`);

--
-- Índices para tabela `tb_visitante`
--
ALTER TABLE `tb_visitante`
  ADD PRIMARY KEY (`rg`);

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `tb_condominio`
--
ALTER TABLE `tb_condominio`
  ADD CONSTRAINT `tb_condominio_ibfk_1` FOREIGN KEY (`empresa`) REFERENCES `tb_empresa` (`codigo`);

--
-- Limitadores para a tabela `tb_contas_condominio`
--
ALTER TABLE `tb_contas_condominio`
  ADD CONSTRAINT `tb_contas_condominio_ibfk_1` FOREIGN KEY (`condominio`) REFERENCES `tb_condominio` (`codigo`);

--
-- Limitadores para a tabela `tb_dedetizacao`
--
ALTER TABLE `tb_dedetizacao`
  ADD CONSTRAINT `tb_dedetizacao_ibfk_1` FOREIGN KEY (`condominio`) REFERENCES `tb_condominio` (`codigo`);

--
-- Limitadores para a tabela `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  ADD CONSTRAINT `tb_funcionario_ibfk_1` FOREIGN KEY (`empresa`) REFERENCES `tb_empresa` (`codigo`);

--
-- Limitadores para a tabela `tb_manutencao_ele`
--
ALTER TABLE `tb_manutencao_ele`
  ADD CONSTRAINT `tb_manutencao_ele_ibfk_1` FOREIGN KEY (`condominio`) REFERENCES `tb_condominio` (`codigo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
