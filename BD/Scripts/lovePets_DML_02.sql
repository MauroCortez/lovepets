USE LovePets;
GO

INSERT INTO Clinica(CNPJ, RazaoSocial, Endereco)
VALUES			   ('99999999999999', 'lovePets', 'Al. Barão de Limeira, 538');
GO

INSERT INTO Veterinario(idClinica, CRMV, NomeVeterinario)
VALUES				   (1, '432551', 'Saulo'),
					   (1, '653655', 'Caique');
GO

INSERT INTO TipoPet(NomeTipoPet)
VALUES			   ('cachorro'),
				   ('gato');
GO

INSERT INTO Dono(NomeDono)
VALUES			('Paulo'),
                ('Odirlei');
GO

INSERT INTO Raca(idTipoPet, NomeRaca)
VALUES			(1, 'poodle'),
				(1, 'labrador'),
				(1, 'SRD'),
				(2, 'siamês');
GO

INSERT INTO Pet(NomePet, idRaca, idDono, DataNascimento)
VALUES		   ('junior', 1, 1, '10/10/2018'),
			   ('loli', 4, 1, '18/05/2017'),
			   ('sammy', 1, 2, '16/06/2016');
GO

INSERT INTO Atendimento(idPet, idVeterinario, Descricao, DataAtendimento)
VALUES				   (1, 1, 'restam 10 dias de vida', '15/07/2021 16:00'),
					   (2, 2, 'o paciente está ok', '16/07/2021 17:00'),
					   (1, 2, 'o paciente está ok', '17/07/2021 10:00');
GO