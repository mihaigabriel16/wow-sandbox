using Common.Constants;
using Common.Interfaces;
using Common.Interfaces.Handlers;
using TBC_5665.Handlers;

namespace TBC_5665
{
    public class Sandbox : ISandbox
    {
        public static Sandbox Instance { get; } = new Sandbox();

        public string RealmName => "TBC Beta (2.0.0.5665-2.0.0.5849) Sandbox";
        public Expansions Expansion => Expansions.TBC;
        public int Build => 5665;
        public int RealmPort => 3724;
        public int RedirectPort => 9002;
        public int WorldPort => 8129;

        public IOpcodes Opcodes => new Opcodes();

        public IAuthHandler AuthHandler => new AuthHandler();
        public ICharHandler CharHandler => new CharHandler();
        public IWorldHandler WorldHandler => new WorldHandler();

        public IPacketReader ReadPacket(byte[] data, bool parse = true) => new PacketReader(data, parse);

    }
}
