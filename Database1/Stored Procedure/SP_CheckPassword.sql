CREATE PROCEDURE [dbo].[SP_CheckPassword]
	@mail nvarchar(200),
	@pwd nvarchar(16)

AS
	SELECT [UserId]
		FROM Utilisateur
		WHERE @mail = [Email] AND HASHBYTES ('SHA2_256', [Salt]+@pwd) = [Password]
RETURN 0