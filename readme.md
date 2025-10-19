# Unreal Gemini Image Generator Plugin (UE 5.6)

**Generate AI images directly inside Unreal Engine 5 using Google Gemini Image API.**  
언리얼 에디터 내에서 **Google Gemini Image API**를 활용해 텍스트 기반 이미지를 바로 생성할 수 있는 플러그인입니다.

---

## ✨ Features

| 기능 | 설명 |
|------|------|
| **텍스트 기반 이미지 생성** | 프롬프트를 입력하면 Gemini API가 이미지를 생성 |
| **에디터 뷰포트 반영** | 현재 화면 정보를 참조해 결과 품질 향상 |
| **다양한 비율 지원** | 1:1, 16:9, 21:9 등 다양한 비율 옵션 제공 |
| **자동 미리보기 스케일링** | 위젯 크기에 맞게 비율 유지, 잘림 없이 표시 |
| **심플한 UI 구성** | 입력 → 비율 선택 → 생성 → 미리보기까지 한 화면에서 가능 |

---

## 🧩 Requirements

- **Unreal Engine 5.6 이상**
- **Google Gemini API Key**
- 모델명: `gemini-2.5-flash-image`

---

## ⚙️ Installation

- 플러그인 폴더를 아래 위치에 배치합니다:
```

YourProject/Plugins/GeminiImageGenerator/

````

1. 언리얼 에디터를 실행하고  
**Edit → Plugins → Gemini Image Generator**를 활성화합니다.

2. **Project Settings → Gemini Image Generator**에서  
Gemini API Key를 입력합니다.
![alt text](https://github.com/online5880/Unreal-Gemini-Image-Generator/blob/main/Images/setting.png?raw=true)

---

## 🖥️ How to Use

1. 에디터 메뉴에서  
**Window → Gemini Image Generator** 실행  
![alt text](https://github.com/online5880/Unreal-Gemini-Image-Generator/blob/main/Images/toolbar.png?raw=true)
1. 프롬프트 입력  
2. 비율 선택 (예: 1:1 / 16:9 / 21:9 등)  
3. “이미지 생성” 클릭  
4. 결과는 위젯 내 미리보기에서 바로 확인 가능  

---

## 📁 Folder Structure

```
GeminiImageGenerator/
├── GeminiImageGenerator.uplugin
├── Resources/
│   ├── Icon128.png
│   └── PluginIcon.svg
├── Binaries/
│   └── Win64/
│       └── GeminiImageGeneratorEditor.dll
└── EditorUtilityWidget/
    └── EUW_GeminiImageGenerator.uasset
```

---

## ⚠️ Notes

* 무료 Gemini API 키는 요청 횟수에 제한이 있습니다.
* 뷰포트가 닫혀 있거나 비활성화된 경우 캡처 기능이 작동하지 않습니다.
* 이 플러그인은 오프라인 상태에서 동작하지 않습니다.

---

## 🧱 Example Prompt

```
"Futuristic city skyline under sunset, ultra wide cinematic 21:9 composition"
```

---

## 📜 License

This plugin is distributed under the MIT License.
© 2025 online5880 (박만혜)

---

## 📬 Contact

* **GitHub:** [https://github.com/online5880](https://github.com/online5880)
* **Email:** [gjtjqkr5880@gmail.com](mailto:gjtjqkr5880@gmail.com)

---

## 🌌 Preview

![alt text](https://github.com/online5880/Unreal-Gemini-Image-Generator/blob/main/Images/preview.png?raw=true)

---