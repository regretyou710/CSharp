-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================

--N:�N��s�J�ƾڮw�ɥHUnicode�榡�x�s
--U:��ƪ�(�ϥΪ̩w�q����)
/*���w��Ʀ檺�w�]��:
	ALTER TABLE [Person].[Contact] 
	ADD [CurrentPoints] int NOT NULL
	DEFAULT 10000 WITH VALUES
*/

--�p�G[Person]�إߪ�Password]�s�b�N����
IF OBJECT_ID(N'[Person].[Password]','U') IS NOT NULL
ALTER TABLE [Person].[Password]  
ADD [Security] nvarchar(5) NOT NULL
DEFAULT N'�C' WITH VALUES
GO
--�P�H�U�w�x�{�ǵL��


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [Sales].[uspCountOrder]
@TerritoryID [int] 
AS
BEGIN
	SELECT COUNT(*) 
	FROM [Sales].[SalesOrderHeader]
	WHERE [TerritoryID] = @TerritoryID
END
GO
