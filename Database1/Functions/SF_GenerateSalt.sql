CREATE FUNCTION [dbo].[SF_GenerateSalt]
(
)
RETURNS NVARCHAR(8)
AS
BEGIN
	DECLARE @saltResult NCHAR(8) ='00000000',
			@randomValue SMALLINT,
			@i SMALLINT
			SET @i = 0;
			WHILE @i <8
				BEGIN
					SET @randomValue = FLOOR(RAND()*10);
					SET @saltResult = CONCAT (@saltResult,@randomValue);
					SET @i = @i+1;
				END
	RETURN @saltResult
END
