// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:4013,x:34120,y:32773,varname:node_4013,prsc:2|diff-5632-OUT,spec-6824-OUT,gloss-7578-OUT,normal-105-OUT,transm-3949-OUT,lwrap-3949-OUT,alpha-4691-OUT,refract-7607-OUT;n:type:ShaderForge.SFN_Color,id:1304,x:32758,y:32311,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_1304,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.2,c3:1,c4:1;n:type:ShaderForge.SFN_Slider,id:4575,x:32408,y:32886,ptovrint:False,ptlb:Reflection,ptin:_Reflection,varname:node_4575,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Vector3,id:927,x:32512,y:32741,varname:node_927,prsc:2,v1:0,v2:0,v3:1;n:type:ShaderForge.SFN_Lerp,id:103,x:32734,y:32774,varname:node_103,prsc:2|A-927-OUT,B-7079-RGB,T-4575-OUT;n:type:ShaderForge.SFN_Tex2d,id:7079,x:32504,y:33012,ptovrint:False,ptlb:Refraction,ptin:_Refraction,varname:node_7079,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7b18a7c30b7b341de96130fc2106b089,ntxv:0,isnm:False|UVIN-4815-UVOUT;n:type:ShaderForge.SFN_Normalize,id:105,x:32922,y:32774,varname:node_105,prsc:2|IN-103-OUT;n:type:ShaderForge.SFN_Slider,id:3949,x:33040,y:32865,ptovrint:False,ptlb:Value,ptin:_Value,varname:node_3949,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Slider,id:9264,x:33040,y:32980,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_9264,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.29,max:1;n:type:ShaderForge.SFN_Multiply,id:7607,x:33118,y:33117,varname:node_7607,prsc:2|A-3562-OUT,B-4384-OUT;n:type:ShaderForge.SFN_Panner,id:4815,x:32278,y:32976,varname:node_4815,prsc:2,spu:0.02,spv:0.02|UVIN-7575-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:7575,x:32080,y:32932,varname:node_7575,prsc:2,uv:0;n:type:ShaderForge.SFN_ComponentMask,id:3562,x:32766,y:33075,varname:node_3562,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-7079-RGB;n:type:ShaderForge.SFN_Multiply,id:4384,x:32766,y:33275,varname:node_4384,prsc:2|A-9275-OUT,B-2963-OUT;n:type:ShaderForge.SFN_Slider,id:9275,x:32357,y:33204,ptovrint:False,ptlb:Distortion,ptin:_Distortion,varname:node_9275,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.48,max:1;n:type:ShaderForge.SFN_Vector1,id:2963,x:32514,y:33330,varname:node_2963,prsc:2,v1:0.2;n:type:ShaderForge.SFN_Multiply,id:5632,x:33039,y:32450,varname:node_5632,prsc:2|A-1304-RGB,B-5385-A;n:type:ShaderForge.SFN_VertexColor,id:5385,x:32758,y:32519,varname:node_5385,prsc:2;n:type:ShaderForge.SFN_Vector1,id:6824,x:33039,y:32601,varname:node_6824,prsc:2,v1:0;n:type:ShaderForge.SFN_Slider,id:7578,x:32882,y:32698,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:node_7578,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.27,max:1;n:type:ShaderForge.SFN_TexCoord,id:5764,x:32378,y:33516,varname:node_5764,prsc:2,uv:0;n:type:ShaderForge.SFN_Add,id:6894,x:32667,y:33620,varname:node_6894,prsc:2|A-5764-V,B-4229-OUT;n:type:ShaderForge.SFN_Slider,id:4229,x:32243,y:33730,ptovrint:False,ptlb:Water FoamV,ptin:_WaterFoamV,varname:node_4229,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.9,max:1;n:type:ShaderForge.SFN_Append,id:8970,x:32850,y:33541,varname:node_8970,prsc:2|A-5764-U,B-6894-OUT;n:type:ShaderForge.SFN_Panner,id:5300,x:33104,y:33531,varname:node_5300,prsc:2,spu:0,spv:0.07|UVIN-8970-OUT;n:type:ShaderForge.SFN_Tex2d,id:6093,x:33397,y:33471,ptovrint:False,ptlb:Foam,ptin:_Foam,varname:node_6093,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:380cd538622e748e7834b7cd62c9d93a,ntxv:3,isnm:False|UVIN-5300-UVOUT;n:type:ShaderForge.SFN_VertexColor,id:8377,x:33359,y:33683,varname:node_8377,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1150,x:33667,y:33467,varname:node_1150,prsc:2|A-6093-R,B-8377-A;n:type:ShaderForge.SFN_Subtract,id:4691,x:34089,y:33397,varname:node_4691,prsc:2|A-1150-OUT,B-3672-OUT;n:type:ShaderForge.SFN_Vector1,id:3672,x:33848,y:33564,varname:node_3672,prsc:2,v1:0.1;proporder:1304-4575-7079-3949-9264-9275-7578-4229-6093;pass:END;sub:END;*/

Shader "Shader Forge/water" {
    Properties {
        _Color ("Color", Color) = (0,0.2,1,1)
        _Reflection ("Reflection", Range(0, 1)) = 0
        _Refraction ("Refraction", 2D) = "white" {}
        _Value ("Value", Range(0, 1)) = 1
        _Opacity ("Opacity", Range(0, 1)) = 0.29
        _Distortion ("Distortion", Range(0, 1)) = 0.48
        _Gloss ("Gloss", Range(0, 1)) = 0.27
        _WaterFoamV ("Water FoamV", Range(0, 1)) = 0.9
        _Foam ("Foam", 2D) = "bump" {}
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
            uniform sampler2D _Refraction; uniform float4 _Refraction_ST;
            uniform float _Value;
            uniform float _Distortion;
            uniform float _Gloss;
            uniform float _WaterFoamV;
            uniform sampler2D _Foam; uniform float4 _Foam_ST;
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
                float4 node_8435 = _Time + _TimeEditor;
                float2 node_4815 = (i.uv0+node_8435.g*float2(0.02,0.02));
                float4 _Refraction_var = tex2D(_Refraction,TRANSFORM_TEX(node_4815, _Refraction));
                float3 normalLocal = normalize(lerp(float3(0,0,1),_Refraction_var.rgb,_Reflection));
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + (_Refraction_var.rgb.rg*(_Distortion*0.2));
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
                float3 diffuseColor = (_Color.rgb*i.vertexColor.a); // Need this for specular when using metallic
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
                float2 node_5300 = (float2(i.uv0.r,(i.uv0.g+_WaterFoamV))+node_8435.g*float2(0,0.07));
                float4 _Foam_var = tex2D(_Foam,TRANSFORM_TEX(node_5300, _Foam));
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,((_Foam_var.r*i.vertexColor.a)-0.1)),1);
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
            uniform sampler2D _Refraction; uniform float4 _Refraction_ST;
            uniform float _Value;
            uniform float _Distortion;
            uniform float _Gloss;
            uniform float _WaterFoamV;
            uniform sampler2D _Foam; uniform float4 _Foam_ST;
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
                float4 node_3213 = _Time + _TimeEditor;
                float2 node_4815 = (i.uv0+node_3213.g*float2(0.02,0.02));
                float4 _Refraction_var = tex2D(_Refraction,TRANSFORM_TEX(node_4815, _Refraction));
                float3 normalLocal = normalize(lerp(float3(0,0,1),_Refraction_var.rgb,_Reflection));
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + (_Refraction_var.rgb.rg*(_Distortion*0.2));
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
                float3 diffuseColor = (_Color.rgb*i.vertexColor.a); // Need this for specular when using metallic
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
                float2 node_5300 = (float2(i.uv0.r,(i.uv0.g+_WaterFoamV))+node_3213.g*float2(0,0.07));
                float4 _Foam_var = tex2D(_Foam,TRANSFORM_TEX(node_5300, _Foam));
                fixed4 finalRGBA = fixed4(finalColor * ((_Foam_var.r*i.vertexColor.a)-0.1),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
