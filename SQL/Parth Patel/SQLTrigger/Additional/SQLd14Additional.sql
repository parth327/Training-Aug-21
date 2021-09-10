--SQL Day 14 Trigger Additional


--Trigger Concepts

--Execute SQL code in response to inserts,updates,or deletes

--Common uses are :


-- Auditing and logging
-- Updating related tables
-- Complex validation

-- Concerns

--Performance
	-- All triggers are part of the current transction
--"Hidden"
	-- Triggers execute behind the scenes

-- Types

-- Instead-Of Triggers

-- Captures the intended operation
-- Common uses
	-- Allow modifications as Views
	-- Mark an item as inactive instead of deleting it
-- After Triggers
	-- Executes after the operation completes successfully
	-- Still part of the same transcation
		-- Can rollback the transcation
	-- Common uses
		-- Log modification
		-- Update tables

-- Trigger Logic

-- Special Table
		-- INSERTED
			-- Provides access to new data for INSERT and UPDATE statements
		-- DELETED
			-- Provides access to old data for UPDATE and DELETE statements
-- Row Count
	-- Consider using SET NOCOUNT ON
		-- Having duplicate row messages can confuse users


