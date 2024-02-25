namespace vintagestory
open Vintagestory.API.Client
open Vintagestory.API.Server
open Vintagestory.API.Config
open Vintagestory.API.Common


type vintagestoryModSystem() =
    inherit ModSystem()
    // Called on server and client
    // Useful for registering block/entity classes on both sides
    override this.Start (api) =
        api.Logger.Notification($"Hello from template mod: {api.Side}");

    override this.StartServerSide(api) =
        api.Logger.Notification($"""Hello from template mod server side: {Lang.Get("vintagestory:hello")}""")

    override this.StartClientSide(api) =
        api.Logger.Notification($"""Hello from template mod client side: {Lang.Get("vintagestory:hello")}""")
