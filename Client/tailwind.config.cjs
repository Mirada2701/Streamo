const defaultTheme = require('tailwindcss/defaultTheme');

/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ['./index.html', './src/**/*.{js,ts,jsx,tsx}'],
  darkMode: 'class',
  theme: {
    fontFamily: {
      satoshi: ['Satoshi', 'sans-serif'],
    },
    colors: {
      current: 'currentColor',
      transparent: 'transparent',

      white: '#FFFFFF',
      black: '#0F172A',
      absoluteblack: '#000000',

      body: '#1E293B',
      bodydark: '#64748B',
      bodydark1: '#94A3B8',
      bodydark2: '#ffffff',

      primary: '#6366F1',   // сучасний фіолетово-синій
      secondary: 'rgba(104,119,131,0.29)', // бірюзово-зелений акцент

      stroke: '#E2E8F0',
      gray: '#6B7280',
      graydark: '#475569',
      'gray-2': '#F1F5F9',
      'gray-3': '#F8FAFC',
      whiten: '#F9FAFB',
      whiter: '#FFFFFF',


      boxdark: '#1E293B',
      'boxdark-2': '#0F172A',
      strokedark: '#334155',
      'form-strokedark': '#CBD5E1',
      'form-input': '#E2E8F0',

      // Метадані / статуси
      'meta-1': '#EF4444', // error
      'meta-2': '#F1F5F9',
      'meta-3': '#22C55E', // success
      'meta-4': '#334155',
      'meta-5': '#3B82F6', // info
      'meta-6': '#F59E0B', // warning
      'meta-7': '#FB7185', // danger-light
      'meta-8': '#F97316', // orange
      'meta-9': '#E5E7EB',

      // Системні кольори
      success: '#16A34A',
      danger: '#DC2626',
      warning: '#FBBF24',
    },

    screens: {
      '2xsm': '375px',
      xsm: '425px',
      '3xl': '2000px',
      ...defaultTheme.screens,
    },
    extend: {
      fontSize: {
        'title-xxl': ['56px', '68px'], // Великі хедери, hero секції
        'title-xl':  ['44px', '58px'], // Потужний сабхедер
        'title-xl2': ['38px', '52px'], // Секційні заголовки
        'title-lg':  ['32px', '44px'], // Основні заголовки
        'title-md2': ['28px', '40px'], // Візуально акцентовані
        'title-md':  ['24px', '36px'], // Базові заголовки
        'title-sm':  ['20px', '30px'], // Підзаголовки
        'title-xsm': ['16px', '24px'], // Найменші тайтли
      },
      spacing: {
        4.5: '1.125rem',
        5.5: '1.375rem',
        6.5: '1.625rem',
        7.5: '1.875rem',
        8.5: '2.125rem',
        9.5: '2.375rem',
        10.5: '2.625rem',
        11: '2.75rem',
        11.5: '2.875rem',
        12.5: '3.125rem',
        13: '3.25rem',
        13.5: '3.375rem',
        14: '3.5rem',
        14.5: '3.625rem',
        15: '3.75rem',
        15.5: '3.875rem',
        16: '4rem',
        16.5: '4.125rem',
        17: '4.25rem',
        17.5: '4.375rem',
        18: '4.5rem',
        18.5: '4.625rem',
        19: '4.75rem',
        19.5: '4.875rem',
        21: '5.25rem',
        21.5: '5.375rem',
        22: '5.5rem',
        22.5: '5.625rem',
        24.5: '6.125rem',
        25: '6.25rem',
        25.5: '6.375rem',
        26: '6.5rem',
        27: '6.75rem',
        27.5: '6.875rem',
        29: '7.25rem',
        29.5: '7.375rem',
        30: '7.5rem',
        31: '7.75rem',
        32.5: '8.125rem',
        34: '8.5rem',
        34.5: '8.625rem',
        35: '8.75rem',
        36.5: '9.125rem',
        37.5: '9.375rem',
        39: '9.75rem',
        39.5: '9.875rem',
        40: '10rem',
        42.5: '10.625rem',
        44: '11rem',
        45: '11.25rem',
        46: '11.5rem',
        47.5: '11.875rem',
        49: '12.25rem',
        50: '12.5rem',
        52: '13rem',
        52.5: '13.125rem',
        54: '13.5rem',
        54.5: '13.625rem',
        55: '13.75rem',
        55.5: '13.875rem',
        59: '14.75rem',
        60: '15rem',
        62.5: '15.625rem',
        65: '16.25rem',
        67: '16.75rem',
        67.5: '16.875rem',
        70: '17.5rem',
        72.5: '18.125rem',
        73: '18.25rem',
        75: '18.75rem',
        90: '22.5rem',
        94: '23.5rem',
        95: '23.75rem',
        100: '25rem',
        115: '28.75rem',
        125: '31.25rem',
        132.5: '33.125rem',
        150: '37.5rem',
        171.5: '42.875rem',
        180: '45rem',
        187.5: '46.875rem',
        203: '50.75rem',
        230: '57.5rem',
        242.5: '60.625rem',
      },
      maxWidth: {
        2.5: '0.625rem',
        3: '0.75rem',
        4: '1rem',
        11: '2.75rem',
        13: '3.25rem',
        14: '3.5rem',
        15: '3.75rem',
        22.5: '5.625rem',
        25: '6.25rem',
        30: '7.5rem',
        34: '8.5rem',
        35: '8.75rem',
        40: '10rem',
        42.5: '10.625rem',
        44: '11rem',
        45: '11.25rem',
        70: '17.5rem',
        90: '22.5rem',
        94: '23.5rem',
        125: '31.25rem',
        132.5: '33.125rem',
        142.5: '35.625rem',
        150: '37.5rem',
        180: '45rem',
        203: '50.75rem',
        230: '57.5rem',
        242.5: '60.625rem',
        270: '67.5rem',
        280: '70rem',
        292.5: '73.125rem',
      },
      maxHeight: {
        35: '8.75rem',
        70: '17.5rem',
        90: '22.5rem',
        550: '34.375rem',
        300: '18.75rem',
      },
      minWidth: {
        22.5: '5.625rem',
        42.5: '10.625rem',
        47.5: '11.875rem',
        75: '18.75rem',
      },
      zIndex: {
        999999: '999999',
        99999: '99999',
        9999: '9999',
        999: '999',
        99: '99',
        9: '9',
        1: '1',
      },
      opacity: {
        65: '.65',
      },
      backgroundImage: {
        video: "url('../images/video/video.png')",
      },
      content: {
        'icon-copy': 'url("../images/icon/icon-copy-alt.svg")',
      },
      transitionProperty: { width: 'width', stroke: 'stroke' },
      borderWidth: {
        6: '6px',
      },

      boxShadow: {
        default: '0px 4px 20px rgba(0,0,0,0.08)', // м'якіша тінь
        card: '0px 2px 8px rgba(0,0,0,0.06)',
        'card-2': '0px 1px 3px rgba(0,0,0,0.08)',
        switcher:
          '0px 2px 4px rgba(0,0,0,0.12), inset 0px 2px 2px #FFFFFF, inset 0px -1px 1px rgba(0,0,0,0.08)',
        'switch-1': '0px 0px 5px rgba(0,0,0,0.12)',
        1: '0px 1px 2px rgba(0,0,0,0.06)',
        2: '0px 1px 4px rgba(0,0,0,0.08)',
        3: '0px 2px 6px rgba(0,0,0,0.10)',
        4: '0px 4px 12px rgba(0,0,0,0.12)',
        6: '0px 6px 20px rgba(0,0,0,0.14)',
        7: '-5px 0 0 #313D4A, 5px 0 0 #313D4A',
        8: '0 0 0 1px #E5E7EB, 0 8px 24px rgba(0,0,0,0.08)',
      },
      dropShadow: {
        1: '0px 1px 1px rgba(0,0,0,0.08)',
        2: '0px 2px 4px rgba(0,0,0,0.10)',
      },
      keyframes: {
        rotating: {
          '0%': { transform: 'rotate(0deg)' },
          '100%': { transform: 'rotate(360deg)' },
        },
        fadeInUp: {
          '0%': { opacity: 0, transform: 'translateY(20px)' },
          '100%': { opacity: 1, transform: 'translateY(0)' },

        },
      },
      animation: {
        'ping-once': 'ping 5s cubic-bezier(0, 0, 0.2, 1)',
        rotating: 'rotating 20s linear infinite',
        'spin-1.5': 'spin 1.5s linear infinite',
        'fade-in-up': 'fadeInUp 0.6s ease-out',
      },
    },
  },
  plugins: [],
};
