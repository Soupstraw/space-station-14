using Content.Shared.Sound;

namespace Content.Server.AirlockPainter
{
    [RegisterComponent]
    public sealed class AirlockPainterComponent : Component
    {
        [DataField("spraySound")]
        public SoundSpecifier SpraySound = new SoundPathSpecifier("/Audio/Effects/spray2.ogg");

        [DataField("sprayTime")]
        public float SprayTime = 3.0f;

        [DataField("isSpraying")]
        public bool IsSpraying = false;

        [DataField("style")]
        public AirlockStyle Style = default!;
    }
}
