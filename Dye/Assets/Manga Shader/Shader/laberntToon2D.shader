Shader "Custom/laberntToon2D" {

	 Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_Color ("Color", color) = (1,1,1,1)
		_Color_SPC ("Color", color) = (1,1,1,1)
		_DiffuseThreshold ("Threshold for Diffuse Colors", Range(0,1))= 0.1
		_Intensity ("Intensity Color", Range(0,1))= 0.1
	}
	SubShader {
		Tags { "RenderType" = "Opaque" }
		CGPROGRAM

		#pragma surface surf Toon
 
		struct Input {
			float2 uv_MainTex;
		};

		uniform half4 _Color;
		uniform half4 _Color_SPC;
		uniform float _DiffuseThreshold;
		uniform float _Intensity;

		sampler2D _MainTex;
		void surf (Input IN, inout SurfaceOutput o) {
		    
			o.Albedo = (tex2D (_MainTex, IN.uv_MainTex).rgb *  _Intensity ) * _Color;
		}
 
		fixed4 LightingToon (SurfaceOutput s, fixed3 lightDir, fixed atten)
		{
			half NdotL = dot(s.Normal, lightDir); 
			//NdotL = tex2D(_RampTex, fixed2(NdotL, 0.5));

			if(NdotL < _DiffuseThreshold){
			    NdotL = _Color_SPC;

			}else{
				NdotL = _Color;
			}

 
			fixed4 c;
			c.rgb = s.Albedo * _LightColor0.rgb * NdotL * 2 *_Color_SPC;
			c.a = s.Alpha;
 
			return c;
		}
 
		ENDCG
	} 
	Fallback "Diffuse"
}