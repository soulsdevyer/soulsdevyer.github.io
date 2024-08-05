/** @type {import('tailwindcss').Config} */
export default {
  content: [
    "./src/**/*.{astro,html,js,jsx,md,mdx,svelte,ts,tsx,vue}",
    "./node_modules/flowbite/**/*.js",
  ],
  theme: {
    extend: {
      colors: {
        "meca-mainBlue": "#0d1b2a",
        "meca-secondaryBlue": "#1c3353",
        "meca-midBlue": "#3d5f86",
        "meca-lightBlue": "#6b8bb1",
        "meca-lightestBlue": "#c5d3de",
      },
    },
  },
  plugins: [require("flowbite/plugin")],
};
