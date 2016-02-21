// --------------------------------------------------------------------------------------
// FAKE build script
// --------------------------------------------------------------------------------------

#I @"packages/FAKE/tools/"
//#I @"packages/xunit/lib/net35/"

#r @"FakeLib.dll"

open Fake
open Fake.AssemblyInfoFile
open Fake.ReleaseNotesHelper
open Fake.Testing
open System
open System.IO

Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

// Project info (used in AssemblyInfo files)
let project = "Tag Connect"
let summary = "Tag Connect"
let company = ""
let copyright = ""

// Properties
let solutionFile = "ImpossibleCompilerError.sln"
let buildDir = "./bin/"

// --------------------------------------------------------------------------------------
// Clean build results
Target "Clean" (fun _ ->
    CleanDirs [buildDir]
)

// --------------------------------------------------------------------------------------
// Build library & test project
Target "Build" (fun _ ->
   !! solutionFile
     |> MSBuildRelease "" "Rebuild"
     |> Log "AppBuild-Output: "
)

// --------------------------------------------------------------------------------------
// Run all targets by default. Invoke 'build <Target>' to override
Target "All" DoNothing

// Dependencies
"Clean"
    ==> "Build"
    ==> "All"

    
RunTargetOrDefault "All"