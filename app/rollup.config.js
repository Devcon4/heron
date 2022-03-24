import babel from '@rollup/plugin-babel';
import commonjs from '@rollup/plugin-commonjs';
// import html from '@rollup/plugin-html';
import { nodeResolve } from '@rollup/plugin-node-resolve';
import html from '@web/rollup-plugin-html';
import copy from 'rollup-plugin-copy';
import dev from 'rollup-plugin-dev';
import livereload from 'rollup-plugin-livereload';
import { terser } from 'rollup-plugin-terser';

const extensions = ['.ts', '.mjs', '.js', '.json', '.node'];

/** @type {import('rollup-plugin-copy').CopyOptions} */
const copyConfig = {
  targets: [
    {
      src: 'src/assets/**/*',
      dest: 'dist/assets',
    },
  ],
};

/** @type {import('rollup').RollupOptions} */
const config = {
  input: ['./src/app.ts'],
  output: {
    dir: 'dist',
    format: 'es',
    name: 'Caracara',
    entryFileNames: '[name].[hash].js',
    chunkFileNames: '[name].[hash].js',
    // manualChunks: {
    //   mwc: [
    //     'node_modules/@material/mwc-base',
    //     'node_modules/@material/mwc-button',
    //     'node_modules/@material/mwc-circular-progress-four-color',
    //     'node_modules/@material/mwc-icon',
    //     'node_modules/@material/mwc-menu',
    //     'node_modules/@material/mwc-select',
    //     'node_modules/@material/mwc-textfield',
    //   ],
    // },
  },
  plugins: [
    nodeResolve({ extensions }),
    commonjs(),
    html({
      input: './src/index.html',
      minify: true,
    }),
    copy(copyConfig),
    // image({
    //   output: `./dist/assets/images`, // default the root
    //   extensions: /\.(png|jpg|jpeg|gif|svg)$/, // support png|jpg|jpeg|gif|svg, and it's alse the default value
    //   exclude: 'node_modules/**',
    //   _slash: true,
    // }),
    babel({
      extensions,
      babelHelpers: 'bundled',
      include: ['src/**/*'],
    }),
  ],
};

const isDevelopment = process.env.NODE_ENV !== 'production';

if (isDevelopment) {
  config.watch = {};
  config.output.sourcemap = true;
  config.plugins = [
    ...config.plugins,
    dev({
      dirs: ['dist'],
      spa: './index.html',
      host: 'localhost',
      port: 4240,
      proxy: [{ from: '/api', to: 'https://localhost:4241/api' }],
    }),
    livereload({
      watch: ['dist'],
    }),
  ];
}

if (!isDevelopment) {
  config.output.sourcemap = false;
  config.plugins = [...config.plugins, terser({})];
}

export default config;
