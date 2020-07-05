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

--N:代表存入數據庫時以Unicode格式儲存
--U:資料表(使用者定義的表)
/*指定資料行的預設值:
	ALTER TABLE [Person].[Contact] 
	ADD [CurrentPoints] int NOT NULL
	DEFAULT 10000 WITH VALUES
*/

--如果[Person]建立的Password]存在就執行
IF OBJECT_ID(N'[Person].[Password]','U') IS NOT NULL
ALTER TABLE [Person].[Password]  
ADD [Security] nvarchar(5) NOT NULL
DEFAULT N'低' WITH VALUES
GO
--與以下預儲程序無關


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
