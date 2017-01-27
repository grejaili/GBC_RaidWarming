// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:4013,x:34314,y:32776,varname:node_4013,prsc:2|diff-6648-OUT,spec-6824-OUT,gloss-7578-OUT,normal-5245-OUT,transm-3949-OUT,lwrap-3949-OUT,alpha-3808-OUT,refract-8334-OUT;n:type:ShaderForge.SFN_Color,id:1304,x:33393,y:31969,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_1304,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.2,c3:1,c4:1;n:type:ShaderForge.SFN_Slider,id:4575,x:31731,y:32696,ptovrint:False,ptlb:Reflection,ptin:_Reflection,varname:node_4575,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:-0.2056979,max:1;n:type:ShaderForge.SFN_Vector3,id:927,x:32080,y:32798,varname:node_927,prsc:2,v1:0,v2:0,v3:1;n:type:ShaderForge.SFN_Lerp,id:103,x:32496,y:32747,varname:node_103,prsc:2|B-927-OUT,T-4575-OUT;n:type:ShaderForge.SFN_Tex2d,id:7079,x:32504,y:33012,ptovrint:False,ptlb:Refraction,ptin:_Refraction,varname:node_7079,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7b18a7c30b7b341de96130fc2106b089,ntxv:0,isnm:False|UVIN-4815-UVOUT;n:type:ShaderForge.SFN_Normalize,id:105,x:32769,y:32655,varname:node_105,prsc:2|IN-103-OUT;n:type:ShaderForge.SFN_Slider,id:3949,x:33710,y:32933,ptovrint:False,ptlb:Value,ptin:_Value,varname:node_3949,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Slider,id:9264,x:32956,y:33122,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_9264,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-5,cur:-5,max:5;n:type:ShaderForge.SFN_Multiply,id:7607,x:33101,y:33262,varname:node_7607,prsc:2|A-3562-OUT,B-4384-OUT;n:type:ShaderForge.SFN_Panner,id:4815,x:32278,y:32976,varname:node_4815,prsc:2,spu:0.02,spv:0.02|UVIN-7575-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:7575,x:32080,y:32932,varname:node_7575,prsc:2,uv:0;n:type:ShaderForge.SFN_ComponentMask,id:3562,x:32766,y:33075,varname:node_3562,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-7079-RGB;n:type:ShaderForge.SFN_Multiply,id:4384,x:32766,y:33275,varname:node_4384,prsc:2|A-9275-OUT,B-2963-OUT;n:type:ShaderForge.SFN_Slider,id:9275,x:32357,y:33204,ptovrint:False,ptlb:Distortion,ptin:_Distortion,varname:node_9275,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.48,max:1;n:type:ShaderForge.SFN_Vector1,id:2963,x:32514,y:33330,varname:node_2963,prsc:2,v1:0.2;n:type:ShaderForge.SFN_Multiply,id:5632,x:33674,y:32108,varname:node_5632,prsc:2|A-1304-RGB,B-5385-A;n:type:ShaderForge.SFN_VertexColor,id:5385,x:33345,y:32174,varname:node_5385,prsc:2;n:type:ShaderForge.SFN_Vector1,id:6824,x:33994,y:32776,varname:node_6824,prsc:2,v1:0;n:type:ShaderForge.SFN_Slider,id:7578,x:33669,y:32818,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:node_7578,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.27,max:1;n:type:ShaderForge.SFN_TexCoord,id:5764,x:32204,y:33485,varname:node_5764,prsc:2,uv:0;n:type:ShaderForge.SFN_Add,id:6894,x:32476,y:33630,varname:node_6894,prsc:2|A-5764-V,B-4229-OUT;n:type:ShaderForge.SFN_Slider,id:4229,x:32031,y:33719,ptovrint:False,ptlb:Water FoamV,ptin:_WaterFoamV,varname:node_4229,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.9,max:1;n:type:ShaderForge.SFN_Append,id:8970,x:32667,y:33513,varname:node_8970,prsc:2|A-5764-U,B-6894-OUT;n:type:ShaderForge.SFN_Panner,id:5300,x:32873,y:33573,varname:node_5300,prsc:2,spu:0,spv:0.07|UVIN-8970-OUT;n:type:ShaderForge.SFN_Tex2d,id:6093,x:33101,y:33458,ptovrint:False,ptlb:Foam,ptin:_Foam,varname:node_6093,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:380cd538622e748e7834b7cd62c9d93a,ntxv:3,isnm:False|UVIN-5300-UVOUT;n:type:ShaderForge.SFN_VertexColor,id:8377,x:33065,y:33720,varname:node_8377,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1150,x:33359,y:33554,varname:node_1150,prsc:2|A-6093-R,B-8377-A;n:type:ShaderForge.SFN_Subtract,id:4691,x:33461,y:32724,varname:node_4691,prsc:2|A-1150-OUT,B-3672-OUT;n:type:ShaderForge.SFN_Vector1,id:3672,x:33211,y:32671,varname:node_3672,prsc:2,v1:0.1;n:type:ShaderForge.SFN_Add,id:6648,x:33936,y:32395,varname:node_6648,prsc:2|A-5632-OUT,B-4691-OUT;n:type:ShaderForge.SFN_Add,id:7353,x:33865,y:33427,varname:node_7353,prsc:2|A-7895-OUT,B-1150-OUT;n:type:ShaderForge.SFN_Slider,id:7895,x:33477,y:33642,ptovrint:False,ptlb:WaterOpacity,ptin:_WaterOpacity,varname:node_7895,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4163665,max:1;n:type:ShaderForge.SFN_Tex2d,id:4591,x:32888,y:32746,ptovrint:False,ptlb:radialOpacity,ptin:_radialOpacity,varname:node_4591,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:a4f26528e90624aeaa97a3e777c76815,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Subtract,id:3808,x:34027,y:33157,varname:node_3808,prsc:2|A-4591-R,B-7353-OUT;n:type:ShaderForge.SFN_Tex2d,id:5418,x:32245,y:32279,ptovrint:False,ptlb:node_5418,ptin:_node_5418,varname:node_5418,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:a1afaedff57e44b9fbf9613015c5cc29,ntxv:0,isnm:False|UVIN-8232-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:9967,x:31702,y:32230,varname:node_9967,prsc:2,uv:0;n:type:ShaderForge.SFN_Slider,id:3498,x:31623,y:32406,ptovrint:False,ptlb:RotationSpeed,ptin:_RotationSpeed,varname:node_3498,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-5,cur:0,max:5;n:type:ShaderForge.SFN_Rotator,id:8232,x:31999,y:32266,varname:node_8232,prsc:2|UVIN-9967-UVOUT,SPD-3498-OUT;n:type:ShaderForge.SFN_Vector3,id:2175,x:32250,y:32118,varname:node_2175,prsc:2,v1:0,v2:0,v3:1;n:type:ShaderForge.SFN_Lerp,id:5245,x:32504,y:32279,varname:node_5245,prsc:2|A-2175-OUT,B-5418-RGB,T-1997-OUT;n:type:ShaderForge.SFN_Slider,id:1997,x:32029,y:32482,ptovrint:False,ptlb:Normal Intensity,ptin:_NormalIntensity,varname:node_1997,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-5,cur:1,max:10;n:type:ShaderForge.SFN_ComponentMask,id:8848,x:32478,y:32423,varname:node_8848,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-5418-RGB;n:type:ShaderForge.SFN_Multiply,id:8334,x:33488,y:32935,varname:node_8334,prsc:2|A-561-OUT,B-3284-OUT;n:type:ShaderForge.SFN_Multiply,id:2112,x:32295,y:32576,varname:node_2112,prsc:2|A-1997-OUT,B-4575-OUT;n:type:ShaderForge.SFN_Multiply,id:9387,x:32695,y:32473,varname:node_9387,prsc:2|A-8848-OUT,B-2112-OUT;n:type:ShaderForge.SFN_Multiply,id:561,x:33155,y:32745,varname:node_561,prsc:2|A-9387-OUT,B-4591-R;n:type:ShaderForge.SFN_VertexColor,id:8080,x:33034,y:32951,varname:node_8080,prsc:2;n:type:ShaderForge.SFN_Multiply,id:3284,x:33327,y:33030,varname:node_3284,prsc:2|A-8080-A,B-9264-OUT;proporder:1304-4575-7079-3949-9264-9275-7578-4229-6093-7895-4591-5418-3498-1997;pass:END;sub:END;*/

Shader "Shader Forge/water" {
    Properties {
        _Color ("Color", Color) = (0,0.2,1,1)
        _Reflection ("Reflection", Range(-1, 1)) = -0.2056979
        _Refraction ("Refraction", 2D) = "white" {}
        _Value ("Value", Range(0, 1)) = 1
        _Opacity ("Opacity", Range(-5, 5)) = -5
        _Distortion ("Distortion", Range(0, 1)) = 0.48
        _Gloss ("Gloss", Range(0, 1)) = 0.27
        _WaterFoamV ("Water FoamV", Range(0, 1)) = 0.9
        _Foam ("Foam", 2D) = "bump" {}
        _WaterOpacity ("WaterOpacity", Range(0, 1)) = 0.4163665
        _radialOpacity ("radialOpacity", 2D) = "white" {}
        _node_5418 ("node_5418", 2D) = "white" {}
        _RotationSpeed ("RotationSpeed", Range(-5, 5)) = 0
        _NormalIntensity ("Normal Intensity", Range(-5, 10)) = 1
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _Reflection;
            uniform float _Value;
            uniform float _Opacity;
            uniform float _Gloss;
            uniform float _WaterFoamV;
            uniform sampler2D _Foam; uniform float4 _Foam_ST;
            uniform float _WaterOpacity;
            uniform sampler2D _radialOpacity; uniform float4 _radialOpacity_ST;
            uniform sampler2D _node_5418; uniform float4 _node_5418_ST;
            uniform float _RotationSpeed;
            uniform float _NormalIntensity;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 screenPos : TEXCOORD5;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.screenPos = o.pos;
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                #if UNITY_UV_STARTS_AT_TOP
                    float grabSign = -_ProjectionParams.x;
                #else
                    float grabSign = _ProjectionParams.x;
                #endif
                i.normalDir = normalize(i.normalDir);
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_3258 = _Time + _TimeEditor;
                float node_8232_ang = node_3258.g;
                float node_8232_spd = _RotationSpeed;
                float node_8232_cos = cos(node_8232_spd*node_8232_ang);
                float node_8232_sin = sin(node_8232_spd*node_8232_ang);
                float2 node_8232_piv = float2(0.5,0.5);
                float2 node_8232 = (mul(i.uv0-node_8232_piv,float2x2( node_8232_cos, -node_8232_sin, node_8232_sin, node_8232_cos))+node_8232_piv);
                float4 _node_5418_var = tex2D(_node_5418,TRANSFORM_TEX(node_8232, _node_5418));
                float3 normalLocal = lerp(float3(0,0,1),_node_5418_var.rgb,_NormalIntensity);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float4 _radialOpacity_var = tex2D(_radialOpacity,TRANSFORM_TEX(i.uv0, _radialOpacity));
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + (((_node_5418_var.rgb.rg*(_NormalIntensity*_Reflection))*_radialOpacity_var.r)*(i.vertexColor.a*_Opacity));
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Gloss;
                float specPow = exp2( gloss * 10.0+1.0);
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float2 node_5300 = (float2(i.uv0.r,(i.uv0.g+_WaterFoamV))+node_3258.g*float2(0,0.07));
                float4 _Foam_var = tex2D(_Foam,TRANSFORM_TEX(node_5300, _Foam));
                float node_1150 = (_Foam_var.r*i.vertexColor.a);
                float3 node_6648 = ((_Color.rgb*i.vertexColor.a)+(node_1150-0.1));
                float3 diffuseColor = node_6648; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, GGXTerm(NdotH, 1.0-gloss));
                float specularPBL = (NdotL*visTerm*normTerm) * (UNITY_PI / 4);
                if (IsGammaSpace())
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                specularPBL = max(0, specularPBL * NdotL);
                float3 directSpecular = (floor(attenuation) * _LightColor0.xyz)*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = dot( normalDirection, lightDirection );
                float3 w = float3(_Value,_Value,_Value)*0.5; // Light wrapping
                float3 NdotLWrap = NdotL * ( 1.0 - w );
                float3 forwardLight = max(float3(0.0,0.0,0.0), NdotLWrap + w );
                float3 backLight = max(float3(0.0,0.0,0.0), -NdotLWrap + w ) * float3(_Value,_Value,_Value);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotLWrap);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((forwardLight+backLight) + ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL)) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,(_radialOpacity_var.r-(_WaterOpacity+node_1150))),1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _Reflection;
            uniform float _Value;
            uniform float _Opacity;
            uniform float _Gloss;
            uniform float _WaterFoamV;
            uniform sampler2D _Foam; uniform float4 _Foam_ST;
            uniform float _WaterOpacity;
            uniform sampler2D _radialOpacity; uniform float4 _radialOpacity_ST;
            uniform sampler2D _node_5418; uniform float4 _node_5418_ST;
            uniform float _RotationSpeed;
            uniform float _NormalIntensity;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 screenPos : TEXCOORD5;
                float4 vertexColor : COLOR;
                LIGHTING_COORDS(6,7)
                UNITY_FOG_COORDS(8)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.screenPos = o.pos;
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                #if UNITY_UV_STARTS_AT_TOP
                    float grabSign = -_ProjectionParams.x;
                #else
                    float grabSign = _ProjectionParams.x;
                #endif
                i.normalDir = normalize(i.normalDir);
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_6146 = _Time + _TimeEditor;
                float node_8232_ang = node_6146.g;
                float node_8232_spd = _RotationSpeed;
                float node_8232_cos = cos(node_8232_spd*node_8232_ang);
                float node_8232_sin = sin(node_8232_spd*node_8232_ang);
                float2 node_8232_piv = float2(0.5,0.5);
                float2 node_8232 = (mul(i.uv0-node_8232_piv,float2x2( node_8232_cos, -node_8232_sin, node_8232_sin, node_8232_cos))+node_8232_piv);
                float4 _node_5418_var = tex2D(_node_5418,TRANSFORM_TEX(node_8232, _node_5418));
                float3 normalLocal = lerp(float3(0,0,1),_node_5418_var.rgb,_NormalIntensity);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float4 _radialOpacity_var = tex2D(_radialOpacity,TRANSFORM_TEX(i.uv0, _radialOpacity));
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + (((_node_5418_var.rgb.rg*(_NormalIntensity*_Reflection))*_radialOpacity_var.r)*(i.vertexColor.a*_Opacity));
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Gloss;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float2 node_5300 = (float2(i.uv0.r,(i.uv0.g+_WaterFoamV))+node_6146.g*float2(0,0.07));
                float4 _Foam_var = tex2D(_Foam,TRANSFORM_TEX(node_5300, _Foam));
                float node_1150 = (_Foam_var.r*i.vertexColor.a);
                float3 node_6648 = ((_Color.rgb*i.vertexColor.a)+(node_1150-0.1));
                float3 diffuseColor = node_6648; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, GGXTerm(NdotH, 1.0-gloss));
                float specularPBL = (NdotL*visTerm*normTerm) * (UNITY_PI / 4);
                if (IsGammaSpace())
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                specularPBL = max(0, specularPBL * NdotL);
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = dot( normalDirection, lightDirection );
                float3 w = float3(_Value,_Value,_Value)*0.5; // Light wrapping
                float3 NdotLWrap = NdotL * ( 1.0 - w );
                float3 forwardLight = max(float3(0.0,0.0,0.0), NdotLWrap + w );
                float3 backLight = max(float3(0.0,0.0,0.0), -NdotLWrap + w ) * float3(_Value,_Value,_Value);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotLWrap);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((forwardLight+backLight) + ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL)) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * (_radialOpacity_var.r-(_WaterOpacity+node_1150)),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}