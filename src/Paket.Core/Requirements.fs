﻿module Paket.Requirements

open Paket
open Paket.PackageSources

type PackageRequirementSource =
| DependenciesFile of string
| Package of string * SemVerInfo   

/// Represents an unresolved package.
[<CustomEquality;CustomComparison>]
type PackageRequirement =
    { Name : string
      VersionRequirement : VersionRequirement
      ResolverStrategy : ResolverStrategy
      Parent: PackageRequirementSource
      Sources : PackageSource list }

    override this.Equals(that) = 
        match that with
        | :? PackageRequirement as that -> this.Name = that.Name && this.VersionRequirement = that.VersionRequirement
        | _ -> false

    override this.ToString() = 
        sprintf "%s %s" this.Name (this.VersionRequirement.ToString())


    override this.GetHashCode() = hash (this.Name,this.VersionRequirement)

    interface System.IComparable with
       member this.CompareTo that = 
          match that with 
          | :? PackageRequirement as that -> 
                if this = that then 0 else
                let c1 =
                    compare 
                       (not this.VersionRequirement.Range.IsGlobalOverride,this.Parent,this.Name)
                       (not that.VersionRequirement.Range.IsGlobalOverride,this.Parent,that.Name)
                if c1 <> 0 then c1 else
                -1 * compare this.VersionRequirement that.VersionRequirement                
          | _ -> invalidArg "that" "cannot compare value of different types" 
