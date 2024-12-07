
const {
	ClassicEditor,
	Autoformat,
	AutoImage,
	Autosave,
	BlockQuote,
	Bold,
	Essentials,
	Heading,
	Highlight,
	ImageBlock,
	ImageCaption,
	ImageInline,
	ImageInsert,
	ImageInsertViaUrl,
	ImageResize,
	ImageStyle,
	ImageTextAlternative,
	ImageToolbar,
	ImageUpload,
	Indent,
	IndentBlock,
	Italic,
	Link,
	LinkImage,
	List,
	ListProperties,
	MediaEmbed,
	Paragraph,
	PasteFromOffice,
	SimpleUploadAdapter,
	SpecialCharacters,
	SpecialCharactersArrows,
	SpecialCharactersCurrency,
	SpecialCharactersEssentials,
	SpecialCharactersLatin,
	SpecialCharactersMathematical,
	SpecialCharactersText,
	Strikethrough,
	TextTransformation,
	TodoList,
	Underline
} = window.CKEDITOR;

const LICENSE_KEY =
	'eyJhbGciOiJFUzI1NiJ9.eyJleHAiOjE3MzQ0Nzk5OTksImp0aSI6IjI0YzAwMDBmLTQ2YjMtNDMyMC1hNDI3LTc1MmEyOWRjZGExZiIsInVzYWdlRW5kcG9pbnQiOiJodHRwczovL3Byb3h5LWV2ZW50LmNrZWRpdG9yLmNvbSIsImRpc3RyaWJ1dGlvbkNoYW5uZWwiOlsiY2xvdWQiLCJkcnVwYWwiLCJzaCJdLCJ3aGl0ZUxhYmVsIjp0cnVlLCJsaWNlbnNlVHlwZSI6InRyaWFsIiwiZmVhdHVyZXMiOlsiKiJdLCJ2YyI6IjE3MDVhZjJhIn0.ubfYq7GxCy2P5Ag-KSvv3iXz_nzWraLakWNgSlPkBhtXZx05Qt_tqpqGvu8MnxZEyG-0rHKsGbWCeVBZ5z8Jag';

const editorConfig = {
	toolbar: {
		items: [
			'heading',
			'|',
			'bold',
			'italic',
			'underline',
			'strikethrough',
			'|',
			'specialCharacters',
			'link',
			'insertImage',
			'mediaEmbed',
			'highlight',
			'blockQuote',
			'|',
			'bulletedList',
			'numberedList',
			'todoList',
			'outdent',
			'indent'
		],
		shouldNotGroupWhenFull: false
	},
	plugins: [
		Autoformat,
		AutoImage,
		Autosave,
		BlockQuote,
		Bold,
		Essentials,
		Heading,
		Highlight,
		ImageBlock,
		ImageCaption,
		ImageInline,
		ImageInsert,
		ImageInsertViaUrl,
		ImageResize,
		ImageStyle,
		ImageTextAlternative,
		ImageToolbar,
		ImageUpload,
		Indent,
		IndentBlock,
		Italic,
		Link,
		LinkImage,
		List,
		ListProperties,
		MediaEmbed,
		Paragraph,
		PasteFromOffice,
		SimpleUploadAdapter,
		SpecialCharacters,
		SpecialCharactersArrows,
		SpecialCharactersCurrency,
		SpecialCharactersEssentials,
		SpecialCharactersLatin,
		SpecialCharactersMathematical,
		SpecialCharactersText,
		Strikethrough,
		TextTransformation,
		TodoList,
		Underline
	],
	heading: {
		options: [
			{
				model: 'paragraph',
				title: 'Paragraph',
				class: 'ck-heading_paragraph'
			},
			{
				model: 'heading1',
				view: 'h1',
				title: 'Heading 1',
				class: 'ck-heading_heading1'
			},
			{
				model: 'heading2',
				view: 'h2',
				title: 'Heading 2',
				class: 'ck-heading_heading2'
			},
			{
				model: 'heading3',
				view: 'h3',
				title: 'Heading 3',
				class: 'ck-heading_heading3'
			},
			{
				model: 'heading4',
				view: 'h4',
				title: 'Heading 4',
				class: 'ck-heading_heading4'
			},
			{
				model: 'heading5',
				view: 'h5',
				title: 'Heading 5',
				class: 'ck-heading_heading5'
			},
			{
				model: 'heading6',
				view: 'h6',
				title: 'Heading 6',
				class: 'ck-heading_heading6'
			}
		]
	},
	image: {
		toolbar: [
			'toggleImageCaption',
			'imageTextAlternative',
			'|',
			'imageStyle:inline',
			'imageStyle:wrapText',
			'imageStyle:breakText',
			'|',
			'resizeImage'
		]
	},
	initialData:
		'<h2>Напишете информацията за рецептата тук.</h2>',
	licenseKey: LICENSE_KEY,
	link: {
		addTargetToExternalLinks: true,
		defaultProtocol: 'https://',
		decorators: {
			toggleDownloadable: {
				mode: 'manual',
				label: 'Downloadable',
				attributes: {
					download: 'file'
				}
			}
		}
	},
	list: {
		properties: {
			styles: true,
			startIndex: true,
			reversed: true
		}
	},
	placeholder: 'Type or paste your content here!',
	simpleUpload: {

	},
	highlight: {
		options: [
			{
				model: 'greenMarker',
				class: 'marker-green',
				title: 'Green marker',
				color: 'var(--ck-highlight-marker-green)',
				type: 'marker'
			},
			{
				model: 'pinkMarker',
				class: 'marker-pink',
				title: 'Pink marker',
				color: 'var(--ck-highlight-marker-pink)',
				type: 'marker'
			},
			{
				model: 'blueMarker',
				class: 'marker-blue',
				title: 'Blue marker',
				color: 'var(--ck-highlight-marker-blue)',
				type: 'marker'
			},
			{
				model: 'redPen',
				class: 'pen-red',
				title: 'Red pen',
				color: 'var(--ck-highlight-pen-red)',
				type: 'pen'
			},
			{
				model: 'greenPen',
				class: 'pen-green',
				title: 'Green pen',
				color: 'var(--ck-highlight-pen-green)',
				type: 'pen'
			}
		]
	}
};

ClassicEditor.create(document.querySelector('#editor'), editorConfig)
	.then(editor => {
		const toolbarElement = editor.ui.view.toolbar.element;

		editor.on('change:isReadOnly', (evt, propertyName, isReadOnly) => {
			if (isReadOnly) {
				toolbarElement.style.display = 'none';
			} else {
				toolbarElement.style.display = 'flex';
			}
		});
	});