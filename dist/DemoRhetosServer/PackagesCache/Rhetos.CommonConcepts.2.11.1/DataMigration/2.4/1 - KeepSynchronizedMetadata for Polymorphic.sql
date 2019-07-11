/*DATAMIGRATION BD03D06C-2EC3-4322-B46F-A88EEFB88572*/ -- Change the script's code only if it needs to be executed again.

-- The following lines are generated by: EXEC Rhetos.HelpDataMigration 'Common', 'KeepSynchronizedMetadata';
EXEC Rhetos.DataMigrationUse 'Common', 'KeepSynchronizedMetadata', 'ID', 'uniqueidentifier';
EXEC Rhetos.DataMigrationUse 'Common', 'KeepSynchronizedMetadata', 'Target', 'nvarchar(256)';
EXEC Rhetos.DataMigrationUse 'Common', 'KeepSynchronizedMetadata', 'Source', 'nvarchar(256)';
EXEC Rhetos.DataMigrationUse 'Common', 'KeepSynchronizedMetadata', 'Context', 'nvarchar(MAX)';
GO

-- The change in Rhetos infrastructure should not result with an automatic update of the existing data on deploy
-- (that might even result with a deployment failure in some cases).
-- If there are any old computed records that where out-of-sync,
-- the admin should compare Source and Target records after the upgrade.
UPDATE
	_Common.KeepSynchronizedMetadata
SET
	Context = 'NORECOMPUTE'
WHERE
	Target LIKE '%[_]Materialized'
	AND Context = 'Rhetos.Dsl.DefaultConcepts.PolymorphicInfo ' + Source

EXEC Rhetos.DataMigrationApplyMultiple 'Common', 'KeepSynchronizedMetadata', 'ID, Target, Source, Context';
