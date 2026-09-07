# Porcelain Inspection — Unity 3D

<p align="left">
  <img src="https://img.shields.io/badge/Unity-6000.6.0f1-000000?style=for-the-badge&logo=unity&logoColor=white" alt="Unity">
  <img src="https://img.shields.io/badge/Linguagem-C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C#">
  <img src="https://img.shields.io/badge/Status-Protótipo-F59E0B?style=for-the-badge" alt="Protótipo">
</p>

Protótipo interativo em **Unity 6 + C#** que simula a inspeção visual de uma
peça de porcelana em 3D. O usuário gira a peça, aproxima a câmera e clica em
pontos de interesse para consultar detalhes de cada região.

## Demonstração

![Demonstração do projeto em execução](assets-repository/interface-1.gif)

## Funcionalidades

- **Rotação orbital** da peça com o mouse (`PorcelainRotator`)
- **Zoom** da câmera pela roda do mouse, com limites de distância (`CameraZoom`)
- **Pontos de inspeção** clicáveis com animação de destaque (`InspectionPoint`)
- **Painel de UI** que exibe título e descrição do ponto selecionado (`InspectionUIManager`)

## Requisitos

- Unity **6000.6.0f1** (Unity 6)
- Pacote **Input System**

## Como executar

1. Clone o repositório.
2. Abra a pasta do projeto pelo **Unity Hub** com a versão indicada acima.
3. Abra a cena principal em `Assets/Scenes/` e pressione **Play**.

## Estrutura

```
Assets/
├── Script/        Scripts de inspeção, rotação e zoom
├── Scenes/        Cenas do projeto
└── Materials/     Materiais da peça de porcelana
```

## Licença

Distribuído sob a licença [MIT](LICENSE).
