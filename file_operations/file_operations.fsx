open System.IO

let write_file file_name str        = File.WriteAllText(file_name, str)
let write_fileA file_name str       = File.AppendAllText(file_name, str)
let read_file file_name : string    = File.ReadAllText(file_name)


(*
    write_file "stracex.txt" "Stracex\n"
    let s1 = read_file "stracex.txt"
    printfn "%s" s1
*)
