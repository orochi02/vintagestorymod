namespace Kevin.vintagestory
    open Vintagestory.API.Client
    open Vintagestory.API.Server
    open Vintagestory.API.Config
    open Vintagestory.API.Common

    type public vintagestoryModSystem() =
        inherit ModSystem()
        // Called on server and client
        // Useful for registering block/entity classes on both sides
        override this.Start api =
            api.Logger.Notification $"kevHello from template mod: {api.Side}"

        override this.StartServerSide api =
            api.Logger.Notification $"""kevHello from template mod server side: {Lang.Get "vintagestoryfsharpmodid:hello" }"""

        override this.StartClientSide api =
            api.Logger.Notification $"""kevHello from template mod client side: {Lang.Get "vintagestoryfsharpmodid:hello"}"""
