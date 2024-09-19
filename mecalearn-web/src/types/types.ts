export interface NavItems {
  label: string;
  href: string;
  iconPath1?: string;
  iconPath2?: string;
}

export interface SubjectCards {
  img: string;
  title: string;
  label: string;
  href: string;
}

export interface Heading1 {
  title: string;
  sub?: string;
}

export interface ImageGallery {
  img: string;
  img1: string;
  img2: string;

  cap?: string;
  cap1?: string;
  cap2?: string;
}
