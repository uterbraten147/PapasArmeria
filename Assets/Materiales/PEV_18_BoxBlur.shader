// Shader created with Shader Forge v1.42 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Enhanced by Antoine Guillon / Arkham Development - http://www.arkham-development.com/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.42;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33675,y:33060,varname:node_3138,prsc:2|custl-2978-OUT;n:type:ShaderForge.SFN_Slider,id:9690,x:32196,y:32822,ptovrint:False,ptlb:offset,ptin:_offset,varname:node_9690,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.0488611,max:0.1;n:type:ShaderForge.SFN_ScreenPos,id:7757,x:32101,y:32581,varname:node_7757,prsc:2,sctp:0;n:type:ShaderForge.SFN_Add,id:406,x:32543,y:32661,varname:node_406,prsc:2|A-7757-U,B-9690-OUT;n:type:ShaderForge.SFN_Append,id:717,x:32543,y:32792,varname:node_717,prsc:2|A-406-OUT,B-7757-V;n:type:ShaderForge.SFN_SceneColor,id:2318,x:32730,y:32792,varname:node_2318,prsc:2|UVIN-717-OUT;n:type:ShaderForge.SFN_Subtract,id:7168,x:32561,y:32949,varname:node_7168,prsc:2|A-7757-U,B-9690-OUT;n:type:ShaderForge.SFN_Append,id:7830,x:32730,y:32979,varname:node_7830,prsc:2|A-7168-OUT,B-7757-V;n:type:ShaderForge.SFN_SceneColor,id:6000,x:32891,y:32979,varname:node_6000,prsc:2|UVIN-7830-OUT;n:type:ShaderForge.SFN_Add,id:9586,x:33066,y:32840,varname:node_9586,prsc:2|A-2318-RGB,B-6000-RGB,C-3249-RGB;n:type:ShaderForge.SFN_Divide,id:2611,x:33261,y:32840,varname:node_2611,prsc:2|A-9586-OUT,B-9271-OUT;n:type:ShaderForge.SFN_Vector1,id:9271,x:33261,y:32985,varname:node_9271,prsc:2,v1:3;n:type:ShaderForge.SFN_ScreenPos,id:1125,x:32919,y:32459,varname:node_1125,prsc:2,sctp:0;n:type:ShaderForge.SFN_SceneColor,id:3249,x:33092,y:32459,varname:node_3249,prsc:2|UVIN-1125-UVOUT;n:type:ShaderForge.SFN_Code,id:2978,x:33018,y:33161,varname:node_2978,prsc:2,code:LwAvAHYAYQByAGkAYQBiAGwAZQBzACAAZABlACAAVQAsACAAVgAKAGYAbABvAGEAdAAgAF8AVQAgAD0AIABfAFUAVgAuAHIAOwAKAGYAbABvAGEAdAAgAF8AVgAgAD0AIABfAFUAVgAuAGcAOwAKAAoALwAvAEQAaQByAGUAYwBjAGkAbwBuACAAZABlAGwAIABiAGwAdQByACAAeAAgADgACgAKAGYAbABvAGEAdAAyACAAXwByACAAPQAgAGYAbABvAGEAdAAyACgAXwBVACAAKwAgAF8ATwAsACAAXwBWACAAKQA7AAoAZgBsAG8AYQB0ADIAIABfAGwAIAA9ACAAZgBsAG8AYQB0ADIAKABfAFUAIAAtACAAXwBPACwAIABfAFYAIAApADsACgBmAGwAbwBhAHQAMgAgAF8AdQAgAD0AIABmAGwAbwBhAHQAMgAoAF8AVQAgACwAIABfAFYAIAArACAAXwBPACAAKQA7AAoAZgBsAG8AYQB0ADIAIABfAGQAIAA9ACAAZgBsAG8AYQB0ADIAKABfAFUAIAAsACAAXwBWACAALQAgAF8ATwApADsACgAKAGYAbABvAGEAdAAyACAAXwByAHUAIAA9ACAAZgBsAG8AYQB0ADIAKABfAFUAIAArACAAXwBPACwAIABfAFYAIAArACAAXwBPACAAKQA7AAoAZgBsAG8AYQB0ADIAIABfAGwAdQAgAD0AIABmAGwAbwBhAHQAMgAoAF8AVQAgAC0AIABfAE8ALAAgAF8AVgAgACsAXwBPACAAKQA7AAoAZgBsAG8AYQB0ADIAIABfAHIAZAAgAD0AIABmAGwAbwBhAHQAMgAoAF8AVQAgACsAIABfAE8AIAAsACAAXwBWACAAKwAgAF8ATwApADsACgBmAGwAbwBhAHQAMgAgAF8AbABkACAAPQAgAGYAbABvAGEAdAAyACgAXwBVACAALQAgAF8ATwAgACwAIABfAFYAIAAtACAAXwBPACkAOwAKAAoALwAvAHMAYwBlAG4AZQAgAEMAbwBsAG8AcgAsACAAZwByAGEAYgBQAGEAcwBzAAoAZgBsAG8AYQB0ADMAIABfAHMAdQBtAD0AIAB0AGUAeAAyAEQAKABfAEcAcgBhAGIAVABlAHgAdAB1AHIAZQAsACAAXwBVAFYAKQA7AAoACgBfAHMAdQBtACAAKwA9ACAAdABlAHgAMgBEACgAXwBHAHIAYQBiAFQAZQB4AHQAdQByAGUALAAgAF8AcgApADsACgBfAHMAdQBtACAAKwA9ACAAdABlAHgAMgBEACgAXwBHAHIAYQBiAFQAZQB4AHQAdQByAGUALAAgAF8AbAApADsACgBfAHMAdQBtACAAKwA9ACAAdABlAHgAMgBEACgAXwBHAHIAYQBiAFQAZQB4AHQAdQByAGUALAAgAF8AdQApADsACgBfAHMAdQBtACAAKwA9ACAAdABlAHgAMgBEACgAXwBHAHIAYQBiAFQAZQB4AHQAdQByAGUALAAgAF8AZAApADsACgBfAHMAdQBtACAAKwA9ACAAdABlAHgAMgBEACgAXwBHAHIAYQBiAFQAZQB4AHQAdQByAGUALAAgAF8AcgB1ACkAOwAKAF8AcwB1AG0AIAArAD0AIAB0AGUAeAAyAEQAKABfAEcAcgBhAGIAVABlAHgAdAB1AHIAZQAsACAAXwBsAHUAKQA7AAoAXwBzAHUAbQAgACsAPQAgAHQAZQB4ADIARAAoAF8ARwByAGEAYgBUAGUAeAB0AHUAcgBlACwAIABfAHIAZAApADsACgBfAHMAdQBtACAAKwA9ACAAdABlAHgAMgBEACgAXwBHAHIAYQBiAFQAZQB4AHQAdQByAGUALAAgAF8AbABkACkAOwAKAAoALwAvAGQAaQB2AGkAZABlAAoACgBfAHMAdQBtACAAPQAgAF8AcwB1AG0ALwA5ADsACgAKAHIAZQB0AHUAcgBuACAAXwBzAHUAbQA7AAoACgAKAAoA,output:2,fname:BoxBlurFunction,width:381,height:489,input:2,input:0,input:1,input_1_label:_Scene,input_2_label:_O,input_3_label:_UV|A-2443-RGB,B-4875-OUT,C-3928-UVOUT;n:type:ShaderForge.SFN_ScreenPos,id:3928,x:32501,y:33345,varname:node_3928,prsc:2,sctp:2;n:type:ShaderForge.SFN_SceneColor,id:2443,x:32696,y:33167,cmnt:GrabPass,varname:node_2443,prsc:2|UVIN-3928-UVOUT;n:type:ShaderForge.SFN_Set,id:1344,x:32264,y:32913,varname:OffsetData,prsc:2|IN-9690-OUT;n:type:ShaderForge.SFN_Get,id:4875,x:32735,y:33310,varname:node_4875,prsc:2|IN-1344-OUT;proporder:9690;pass:END;sub:END;*/

Shader "Shader Forge/PEV_18_BoxBlur" {
    Properties {
        _offset ("offset", Range(0, 0.1)) = 0.0488611
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
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #ifndef UNITY_PASS_FORWARDBASE
            #define UNITY_PASS_FORWARDBASE
            #endif //UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu switch vulkan 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform float _offset;
            float3 BoxBlurFunction( float3 _Scene , float _O , float2 _UV ){
            //variables de U, V
            float _U = _UV.r;
            float _V = _UV.g;
            
            //Direccion del blur x 8
            
            float2 _r = float2(_U + _O, _V );
            float2 _l = float2(_U - _O, _V );
            float2 _u = float2(_U , _V + _O );
            float2 _d = float2(_U , _V - _O);
            
            float2 _ru = float2(_U + _O, _V + _O );
            float2 _lu = float2(_U - _O, _V +_O );
            float2 _rd = float2(_U + _O , _V + _O);
            float2 _ld = float2(_U - _O , _V - _O);
            
            //scene Color, grabPass
            float3 _sum= tex2D(_GrabTexture, _UV);
            
            _sum += tex2D(_GrabTexture, _r);
            _sum += tex2D(_GrabTexture, _l);
            _sum += tex2D(_GrabTexture, _u);
            _sum += tex2D(_GrabTexture, _d);
            _sum += tex2D(_GrabTexture, _ru);
            _sum += tex2D(_GrabTexture, _lu);
            _sum += tex2D(_GrabTexture, _rd);
            _sum += tex2D(_GrabTexture, _ld);
            
            //divide
            
            _sum = _sum/9;
            
            return _sum;
            
            
            
            
            }
            
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 projPos : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
////// Lighting:
                float OffsetData = _offset;
                float3 finalColor = BoxBlurFunction( tex2D( _GrabTexture, sceneUVs.rg).rgb , OffsetData , sceneUVs.rg );
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
