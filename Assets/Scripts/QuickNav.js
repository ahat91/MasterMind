#pragma strict

function OnClick () {

  switch (this.gameObject.name)
  {
    case "Settings":
      Application.LoadLevel("Settings");
      break;
    case "Home":
      Application.LoadLevel("Scene01");
      break;
    case "Data":
        Application.LoadLevel("Data");
      break;
  }
}