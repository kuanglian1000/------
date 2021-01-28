-- SOP-DMV筆記

/*
  利用DMV觀察查詢執行時的各個環節資訊,從中找到可修正或調整的地方,以提升查詢效率
  - 查詢的執行計劃(cached plan)
  - 使用哪些索引(what indexes were used)
  - 哪些索引查詢想用卻無法使用,因為索引遺失(what indexes the query would like to use but can't, because they're missing.)
  - 發生多少 I/O(實體或邏輯)
  - 查詢執行時間
  - 等待其他資源的時間
  - 有哪些資源是查詢所等待的

  1.所有 DMV & DMF 都隸屬於 <sys> schema
  2.所有 DMV 長像 sys.dm_<subsystem name>

*/

-- 目前執行的requests有哪些
SELECT * FROM sys.dm_exec_requests;

/*
  如何使用DMV呢?
  1.1.2. 彙總結果,並作前後期差異比較
  1.1.3. 考慮DMV執行,是否會影響SQLServer效能
          (大部份不會,但是某些DMV確實會影響。
          例:計算索引分割程度的 sys.dm_db_index_physical_stats，就會影響)
  1.1.4. SQL Server內有哪些可用DMV項目?
*/

-- 查詢可用的DMV項目
SELECT name , type_desc
FROM sys.system_objects
WHERE name LIKE 'dm_%'
ORDER BY name;

/*
  1.2 DMV可以解決哪些問題呢？
    1.2.1. Diagnosing problems(診斷問題所在)
      問題範例:解決USER反應查詢太慢的效能問題
      a.利用DMV檢查查詢執行計劃
        , 如何存取資料
        , 使用哪些資源(例:是否使用了索引 或 Table scan) 
        , 統計資訊是否過期
        , 辨別任何遺失索引
      b.找出問題點後, 再提出對策
      c.也有可能是查詢太複雜且包含大量的函式所造成 , 這時可拆解為較小步驟也是解法之一
    1.2.2. Performance tuning(效能調整,ex.通常愈少IO,反應較快的查詢)
      a.使用建議作法對診斷出來的問題，進行調整 == Performance tuning.
        ex.applying a missing index
        ex.remove contention(爭奪)/blocking(阻擋)
        ex.determining the degree of fragmentation.
      b.任何改善的衡量會反應在 <執行時間> or <I/O counts>
      c.Performance tuning 是個反覆過程(改善後, 再決定是否必須作到極緻, 或將焦點放在其他更重要的問題上)
    1.2.3. Monitoring(監控 , sys.dm_exec_..)
      a.有時候,問題發生在夜間批次處理, 回報 timeoue or slow_running queries.
        => 這時, 找出當下執行的SQL command(利用 排程器 or sp_who2)




*/