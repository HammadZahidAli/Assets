using UnityEngine;
using System.Collections;

public class TilesBG : MonoBehaviour {

	public int TextureSize = 32;
	public bool scaleVertical;
	public bool scaleHorizontal;

	// Use this for initialization
	void Start () {
		var newWidth = !scaleHorizontal? 1: Mathf.Ceil(Screen.width/ PixelsPerfectCamera.pixelperunit * TextureSize );
		var newHeight = !scaleVertical? 1 : Mathf.Ceil(Screen.height/ PixelsPerfectCamera.pixelperunit * TextureSize );

		transform.localScale = new Vector3(newWidth * TextureSize, newHeight * TextureSize , 1);
		GetComponent<Renderer> ().material.mainTextureScale = new Vector3 (newWidth, newHeight,1);

	}


}
