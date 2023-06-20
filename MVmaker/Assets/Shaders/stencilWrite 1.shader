Shader "Unlit/PortalShader"
{
	Properties
	{
		[IntRange] _StencilID("Stencil ID", Range(1, 255)) = 1
	}
		
	SubShader
	{
		Tags
		{
			
			"RenderType" = "Opaque"
			
			"RenderPipeline" = "UniversalPipeline"
			"Queue" = "Geometry -2"
		}

		Pass
		{
			Blend Zero One
			ZWrite off

			Stencil
			{
				Ref [_StencilID]
				Comp Always
				Pass Replace
				Fail Keep
				
			}
			Cull off
			
			
		}
	}
}