Shader "Unlit/ActiveWire"{
    Properties{
        _MainTex ("Texture", 2D) = "white" {}

        _Value ("Value",Float) = 1.0

         _Color ("Color",Color) = (1,1,1,1)

        _Scale ("UV Scale",Float) = 0.1

        _Offset("UV Offset",Float) = 0

        _ColorA ("ColorA",Color) = (1,1,1,1)

        _ColorB ("ColorB",Color) = (1,1,1,1)

        _ColorStart ("ColorStart", Range(0,1)) = 0

        _ColorEnd("ColorEnd", Range(0,1)) = 1

        _WaveAmp("WaveAmp", Range(0,0.4)) = 0.01
    }
    SubShader{
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass{
            CGPROGRAM
            #pragma vertex vert


            #include "UnityCG.cginc"

            struct MeshData{
                float4 vertex : POSITION;  // паозиция вершины
 
                float3 normals: NORMAL;  // нормаль - направление в которое смотрит вершина

                float4 tangent: TANGENT; //  направление касательных(4 компонент - информация о синусе)

                float4 color: COLOR;// цвет вершины (rgba-model)

                float2 uv0 : TEXCOORD0; // координаты UV diffuse/nomal map/texture

                float2 uv1: TEXCOORD1; //lightmap coordinates
            };

            struct Interpolators{
                float2 uv : TEXCOORD0;

                float4 vertex : SV_POSITION; //clip space postion
            };


            Interpolators vert (MeshData v){
                 Interpolators o;

                o.vertex = UnityObjectToClipPos(v.vertex); //localspace to clip space (матричное умножение)

                return o;
            }

            fixed4 frag (v2f i) : SV_Target{
                
            }
            ENDCG
        }
    }
}
