#if INTERACTIVE
#r @"..\packages\SQLProvider\lib\net451\FSharp.Data.SqlProvider.dll"
#r @"..\packages\Npgsql\lib\net451\Npgsql.dll"
#endif


open FSharp.Data.Sql
open System
open System.IO
open Npgsql
open NpgsqlTypes




let [<Literal>] dbVendor = Common.DatabaseProviderTypes.POSTGRESQL
let [<Literal>] connString = "Host=localhost;Database=BARZ;Username=postgres;Password=root"
let [<Literal>] connStringName = "DefaultConnectionString"
let [<Literal>] resPath = __SOURCE_DIRECTORY__ + @"\..\packages\Npgsql\lib\net451"
let [<Literal>] indivAmount = 1000
let [<Literal>] useOptTypes = false

type sql = SqlDataProvider<dbVendor, connString,"",resPath,indivAmount,useOptTypes>


/// just get database context
let getDbx() =
    sql.GetDataContext()

let dbx = getDbx()
let table1 = dbx.Public.Jpnciw1Tbl
