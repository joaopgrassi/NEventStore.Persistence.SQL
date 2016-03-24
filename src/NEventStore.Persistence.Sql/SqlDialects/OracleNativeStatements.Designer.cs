﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NEventStore.Persistence.Sql.SqlDialects {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class OracleNativeStatements {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OracleNativeStatements() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NEventStore.Persistence.Sql.SqlDialects.OracleNativeStatements", typeof(OracleNativeStatements).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AND CommitSequence &gt; :CommitSequence.
        /// </summary>
        internal static string AddCommitSequence {
            get {
                return ResourceManager.GetString("AddCommitSequence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*AppendSnapshotToCommit*/
        ///INSERT INTO Snapshots   
        ///  (BucketId, StreamId, StreamRevision, Payload)  
        ///SELECT :BucketId, :StreamId, :StreamRevision, :Payload FROM SYS.DUAL 
        ///WHERE	EXISTS
        ///	(
        ///    SELECT * FROM COMMITS 
        ///    WHERE	BucketId = :BucketId AND StreamId = :StreamId
        ///      AND	(StreamRevision - Items) &lt;= :StreamRevision
        ///	)
        /// AND NOT EXISTS
        ///	(
        ///    SELECT * FROM SNAPSHOTS 
        ///    WHERE	BucketId = :BucketId AND StreamId = :StreamId
        ///      And	Streamrevision = :Streamrevision
        ///	).
        /// </summary>
        internal static string AppendSnapshotToCommit {
            get {
                return ResourceManager.GetString("AppendSnapshotToCommit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///   DELETE FROM Snapshots WHERE BucketId =:BucketId AND StreamId = :StreamId;
        ///   DELETE FROM Commits WHERE BucketId = :BucketId AND StreamId = :StreamId;
        ///END;.
        /// </summary>
        internal static string DeleteStream {
            get {
                return ResourceManager.GetString("DeleteStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN
        ///  EXECUTE IMMEDIATE (&apos;DROP TABLE Snapshots PURGE&apos;);
        ///  EXECUTE IMMEDIATE (&apos;DROP TABLE Commits PURGE&apos;);
        ///  EXECUTE IMMEDIATE (&apos;DROP SEQUENCE Commit_CheckpointNumber&apos;);
        ///END;.
        /// </summary>
        internal static string DropTables {
            get {
                return ResourceManager.GetString("DropTables", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*DuplicateCommit*/
        ///SELECT CAST( COUNT(*) AS NUMBER(8,0) )
        ///FROM Commits 
        ///WHERE	(
        ///  BucketId = :BucketId AND StreamId = :StreamId
        ///  AND CommitId = :CommitId
        ///).
        /// </summary>
        internal static string DuplicateCommit {
            get {
                return ResourceManager.GetString("DuplicateCommit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*GetCommitsFromBucketAndCheckpoint*/
        ///SELECT BucketId, StreamId, StreamIdOriginal, StreamRevision, CommitId, CommitSequence, CommitStamp, CheckpointNumber, Headers, Payload
        ///FROM Commits 
        ///WHERE BucketId = :BucketId AND CheckpointNumber &gt; :CheckpointNumber
        ///ORDER BY CheckpointNumber
        ///WHERE ROWNUM &lt;= :Limit;.
        /// </summary>
        internal static string GetCommitsFromBucketAndCheckpoint {
            get {
                return ResourceManager.GetString("GetCommitsFromBucketAndCheckpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*GetCommitsFromInstant*/
        ///SELECT BucketId, StreamId, StreamIdOriginal, StreamRevision, CommitId, CommitSequence, CommitStamp, CheckpointNumber, Headers, Payload
        ///FROM Commits 
        ///WHERE BucketId = :BucketId AND CommitStamp &gt;= :CommitStamp
        ///ORDER BY CommitStamp, StreamId, CommitSequence.
        /// </summary>
        internal static string GetCommitsFromInstant {
            get {
                return ResourceManager.GetString("GetCommitsFromInstant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*GetCommitsFromStartingRevision*/
        ///SELECT BucketId, StreamId, StreamIdOriginal, StreamRevision, CommitId, CommitSequence, CommitStamp, CheckpointNumber, Headers, Payload
        ///FROM Commits
        ///WHERE BucketId = :BucketId AND StreamId = :StreamId
        ///   AND StreamRevision &gt;= :StreamRevision
        ///   AND (StreamRevision - Items) &lt; :MaxStreamRevision
        ///   AND CommitSequence &gt; :CommitSequence
        ///ORDER BY CommitSequence.
        /// </summary>
        internal static string GetCommitsFromStartingRevision {
            get {
                return ResourceManager.GetString("GetCommitsFromStartingRevision", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*GetCommitsSinceCheckpoint*/
        ///SELECT BucketId, StreamId, StreamIdOriginal, StreamRevision, CommitId, CommitSequence, CommitStamp, CheckpointNumber, Headers, Payload
        ///FROM Commits 
        ///WHERE  CheckpointNumber &gt; :CheckpointNumber
        ///ORDER BY CheckpointNumber
        ///WHERE ROWNUM &lt;= :Limit;.
        /// </summary>
        internal static string GetCommitsSinceCheckpoint {
            get {
                return ResourceManager.GetString("GetCommitsSinceCheckpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*GetSnapshot*/
        ///SELECT *
        ///FROM  Snapshots 
        ///WHERE BucketId = :BucketId AND StreamId = :StreamId
        /// AND	StreamRevision  &lt;= :StreamRevision
        /// AND	ROWNUM &lt;= (:Skip + 1) AND ROWNUM  &gt; :Skip
        ///ORDER BY StreamRevision DESC.
        /// </summary>
        internal static string GetSnapshot {
            get {
                return ResourceManager.GetString("GetSnapshot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*GetStreamsRequiringSnapshots*/
        ///SELECT BucketId, StreamId, StreamIdOriginal, StreamRevision, SnapshotRevision
        ///FROM (
        ///  SELECT C.BucketId, C.StreamId, C.StreamIdOriginal, MAX(C.StreamRevision) AS StreamRevision, MAX(COALESCE(S.StreamRevision, 0)) AS SnapshotRevision
        ///  FROM  Commits C LEFT OUTER JOIN Snapshots S
        ///    ON C.BucketId = :BucketId AND C.StreamId = S.StreamId AND C.StreamRevision &gt;= S.StreamRevision
        ///  GROUP BY C.StreamId, C.BucketId, C.StreamIdOriginal
        ///  HAVING MAX(C.StreamRevision) &gt;= MAX(C [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetStreamsRequiringSnapshots {
            get {
                return ResourceManager.GetString("GetStreamsRequiringSnapshots", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*InitializeStorage*/
        ///DECLARE table_count INTEGER;
        ///BEGIN 
        ///  SELECT COUNT (OBJECT_ID) INTO table_count FROM USER_OBJECTS WHERE EXISTS (
        ///    SELECT OBJECT_NAME FROM USER_OBJECTS WHERE (OBJECT_NAME = &apos;COMMITS&apos; AND OBJECT_TYPE = &apos;TABLE&apos;));
        ///IF table_count = 0 THEN DBMS_OUTPUT.PUT_LINE (&apos;Creating the Commits table&apos;);
        ///  EXECUTE IMMEDIATE (
        ///   &apos;CREATE TABLE Commits(
        ///      BucketId varchar2(40) NOT NULL,
        ///      StreamId char(40) NOT NULL,
        ///      StreamIdOriginal nvarchar2(1000) NOT NULL,
        ///      StreamRevisio [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InitializeStorage {
            get {
                return ResourceManager.GetString("InitializeStorage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*LimitedQueryFormat*/
        ///SELECT OuterQuery.* FROM (
        ///  SELECT InnerQuery.*, ROWNUM AS ROW_NUMBER_VAL FROM (
        ///    {0}    
        ///  ) InnerQuery
        ///) OuterQuery
        ///WHERE ROW_NUMBER_VAL &gt; :Skip AND ROW_NUMBER_VAL &lt;= (:Limit + :Skip).
        /// </summary>
        internal static string LimitedQueryFormat {
            get {
                return ResourceManager.GetString("LimitedQueryFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*MarkCommitAsDispatched*/
        ///UPDATE Commits   
        ///SET Dispatched = 1
        ///WHERE CAST(BucketId AS NVARCHAR2(40)) = :BucketId
        /// AND StreamId  = :StreamId
        /// AND CommitSequence  = :CommitSequence.
        /// </summary>
        internal static string MarkCommitAsDispatched {
            get {
                return ResourceManager.GetString("MarkCommitAsDispatched", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*PagedQueryFormat*/
        ///SELECT *
        ///FROM ( {0},
        ///       ROW_NUMBER() OVER({1}) AS ROW_NUMBER_VAL
        ///       {2}
        ///) PagedQueryFormat
        ///WHERE ROW_NUMBER_VAL &gt; :Skip AND ROW_NUMBER_VAL &lt;= (:Limit + :Skip).
        /// </summary>
        internal static string PagedQueryFormat {
            get {
                return ResourceManager.GetString("PagedQueryFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*PersistCommit*/
        ///DECLARE
        ///   checkPointNumber NUMBER;
        ///BEGIN
        ///INSERT INTO Commits (  
        ///    BucketId,
        ///    StreamId, 
        ///    StreamIdOriginal,
        ///    CommitId, 
        ///    CommitSequence, 
        ///    StreamRevision, 
        ///    Items, 
        ///    CommitStamp, 
        ///    Headers, 
        ///    Payload
        ///)  
        ///VALUES ( 
        ///    :BucketId,
        ///    :StreamId, 
        ///    :StreamIdOriginal, 
        ///    :CommitId, 
        ///    :CommitSequence, 
        ///    :StreamRevision, 
        ///    :Items, 
        ///    :CommitStamp, 
        ///    :Headers, 
        ///    :Payload
        ///)
        ///RETURNING CheckpointNumber INTO checkPointNum [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PersistCommit {
            get {
                return ResourceManager.GetString("PersistCommit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*PurgeStorage*/
        ///DECLARE row_count INTEGER;
        ///BEGIN
        ///  SELECT COUNT(1) INTO row_count FROM Snapshots WHERE BucketId = :BucketId;
        ///  IF row_count != 0 THEN
        ///    EXECUTE IMMEDIATE (&apos;TRUNCATE TABLE Snapshots&apos;);
        ///  ELSE
        ///    DBMS_OUTPUT.PUT_LINE(&apos;The Snapshots table has already been purged.&apos;);
        ///  END IF;
        ///  SELECT COUNT(1) INTO row_count FROM Commits WHERE BucketId = :BucketId;
        ///  IF row_count != 0 THEN
        ///    EXECUTE IMMEDIATE (&apos;TRUNCATE TABLE Commits&apos;);
        ///  ELSE
        ///    DBMS_OUTPUT.PUT_LINE(&apos;The Commits table has a [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PurgeBucket {
            get {
                return ResourceManager.GetString("PurgeBucket", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*PurgeStorage*/
        ///DECLARE row_count INTEGER;
        ///BEGIN
        ///  SELECT COUNT(1) INTO row_count FROM Snapshots;
        ///  IF row_count != 0 THEN
        ///    EXECUTE IMMEDIATE (&apos;TRUNCATE TABLE Snapshots&apos;);
        ///  ELSE
        ///    DBMS_OUTPUT.PUT_LINE(&apos;The Snapshots table has already been purged.&apos;);
        ///  END IF;
        ///  SELECT COUNT(1) INTO row_count FROM Commits;
        ///  IF row_count != 0 THEN
        ///    EXECUTE IMMEDIATE (&apos;TRUNCATE TABLE Commits&apos;);
        ///  ELSE
        ///    DBMS_OUTPUT.PUT_LINE(&apos;The Commits table has already been purged.&apos;);
        ///  END IF;
        ///  EXCEPTION WHEN OT [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PurgeStorage {
            get {
                return ResourceManager.GetString("PurgeStorage", resourceCulture);
            }
        }
    }
}
