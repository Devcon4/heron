const makeHtmlAttributes = (attributes) => {
  if (!attributes) {
    return '';
  }
  const keys = Object.keys(attributes);
  // eslint-disable-next-line no-param-reassign
  return keys.reduce(
    (result, key) => (result += ` ${key}="${attributes[key]}"`),
    ''
  );
};

/** @type {(options: import('@rollup/plugin-html').RollupHtmlOptions, entryPointWhitelist: string[]) => string} */
export const indexHtml = (
  { attributes, meta, title, files, publicPath, fileName },
  entryPointWhitelist
) => {
  const scripts = (files.js || [])
    .filter((f) => entryPointWhitelist.some((e) => f.fileName.includes(e)))
    .map(({ fileName }) => {
      const attrs = makeHtmlAttributes(attributes.script);
      return `<script src="${publicPath}${fileName}"${attrs}></script>`;
    })
    .join('\n');
  const links = (files.css || [])
    .map(({ fileName }) => {
      const attrs = makeHtmlAttributes(attributes.link);
      return `<link href="${publicPath}${fileName}" rel="stylesheet"${attrs}>`;
    })
    .join('\n');
  const metas = meta
    .map((input) => {
      const attrs = makeHtmlAttributes(input);
      return `<meta${attrs}>`;
    })
    .join('\n');

  return `
    <!DOCTYPE html>
    <html ${makeHtmlAttributes(attributes.html)}>
      <head>
        <meta name="viewport" content="width=device-width, minimum-scale=1.0" />
        <meta charset="utf-8">
        <link rel="shortcut icon">
        <base href="/">
        <link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500" rel="stylesheet">
        <link href="https://fonts.googleapis.com/css?family=Material+Icons&display=block" rel="stylesheet">
        ${metas}
        <title>${title}</title>
        ${links}
        <style>
          html, body {
            display: flex;
            flex-direction: column;
            flex: 1;
            margin: 0;
            min-height: 100%;
          }
          
          body {  
            --on: inherit;
            --off: ;
            
            --light: var(--on);
            --dark: var(--off);
            
            --heroLightShade: var(--light, var(--hero4)) var(--dark, var(--hero2));
            --heroLightAccent: var(--light, var(--hero5)) var(--dark, var(--hero1));
            --heroMain: var(--light, var(--hero9)) var(--dark, var(--hero9));
            --heroDarkAccent: var(--light, var(--hero2)) var(--dark, var(--hero4));
            --heroDarkShade: var(--light, var(--hero1)) var(--dark, var(--hero5));
            --heroText: var(--light, var(--hero2)) var(--dark, var(--hero4));

            --mdc-theme-primary: var(--heroMain);
            --mdc-theme-secondary: var(--heroDarkAccent);
            --mdc-theme-surface: var(--heroLightAccent);
            --mdc-theme-background: var(--heroLightShade);

            /* Raw are RGB versions. Useful to compose more complex colors ex: rgba(var(--hero0-raw), .2) */
            --hero0-raw: 74, 75, 81;
            --hero1-raw: 86, 87, 94;
            --hero2-raw: 51, 52, 56;
            --hero3-raw: 32, 34, 36;
            --hero4-raw: 240, 247, 252;
            --hero5-raw: 218, 226, 232;
            --hero6-raw: 170, 181, 191;
            --hero7-raw: 242, 79, 19;
            --hero8-raw: 242, 190, 34;
            --hero9-raw: 242, 79, 19;
            --hero10-raw: 242, 79, 19;
            --hero11-raw: 230, 197, 103;
            --hero12-raw: 68, 126, 179;
            --hero13-raw: 161, 205, 68;
            --hero14-raw: 217, 56, 48;
            --hero15-raw: 245, 133, 127;

            /* Duplicated for better ergonomics in devtools */
            /* Dark colors. */
            --hero0: rgb(74, 75, 81);
            --hero1: rgb(86, 87, 94);
            --hero2: rgb(51, 52, 56);
            --hero3: rgb(32, 34, 36);

            /* Light colors. */
            --hero4: rgb(240, 247, 252);
            --hero5: rgb(218, 226, 232);
            --hero6: rgb(170, 181, 191);

            /* Primary colors. */
            --hero7: rgb(242, 79, 19);
            --hero8: rgb(242, 190, 34);
            --hero9: rgb(242, 79, 19);
            --hero10: rgb(242, 79, 19);
            
            /* Action colors. */
            --hero11: rgb(230, 197, 103);
            --hero12: rgb(68, 126, 179);
            --hero13: rgb(161, 205, 68);
            --hero14: rgb(217, 56, 48);
            --hero15: rgb(245, 133, 127);
            
            background-color: var(--heroLightShade);
            color: var(--heroText);

            font-family: roboto;

          }
          
          @media (prefers-color-scheme: dark) {
            body {
              --light: var(--off);
              --dark: var(--on);
            }
          }
        </style>
      </head>
      <body>
        <hero-app></hero-app>
        ${scripts}
      </body>
    </html>`;
};
